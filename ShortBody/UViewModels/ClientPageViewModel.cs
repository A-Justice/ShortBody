using ShortBody.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class ClientPageViewModel : DashBoardViewModel, IDataErrorInfo
    {


        #region privateVariable
        Client newClient;
        private string error;
        private string searchBy;
        private string searchString;

        #endregion

        #region PublicProperties

        public string SearchBy
        {
            get { return searchBy; }
            set {
                searchBy = value;
                OnPropertyChanged(); }
        }

        public string SearchString
        {
            get { return searchString; }
            set { searchString = value; OnPropertyChanged(); }
        }


        public Client NewClient
        {
            get
            {
                return newClient;
            }
            set
            {
                newClient = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand DeleteClientCommand { get; set; }
        public RelayCommand SaveClientsCommand { get; set; }

        public RelayCommand SaveNewClientCommand { get; set; }


        public int? allClientsSelectedId { get; set; }

        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand ClearBoxes { get;  set; }
        public RelayCommand SearchClientCommand { get; private set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewClient")
                {
                    return "Please Provide values for all fields";
                }
                if(columnName == "duplicate")
                {
                    return "User with the same credentials already exists";
                }
                return null;
            }
        }
        #endregion

        #region Constructors
        public ClientPageViewModel()
        {
            newClient = new Client();
            DeleteClientCommand = new RelayCommand(delete_E, delete_C);
            SaveClientsCommand = new RelayCommand(saveCs_E, saveCs_C);
            ClearBoxes = new RelayCommand(cBoxes_E, cBoxes_C);
            clientChanged += ClientPageViewModel_clientChanged;
            AllClients = allClients;
            SaveNewClientCommand = new RelayCommand(saveNc_E, saveNc_C);
            SearchClientCommand = new RelayCommand(_ =>
            {
                SearchClient();
            });
        }



        #endregion

        #region EventMethods
        private void ClientPageViewModel_clientChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        #region CommandMethods
        private void cBoxes_E(object obj)
        {
            NewClient = new Client();
        }

        private bool cBoxes_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Can Execute Method for saving a new client
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private bool saveNc_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Execute Method for saving a new client
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private void saveNc_E(object obj)
        {
            
            //Check if the client has already been added
            var client = db.Clients.Where(i => i.Email == newClient.Email && i.Phone == newClient.Phone && i.Name == newClient.Name).FirstOrDefault();
            bool IsClientValid = ValidateNewClient(NewClient);
            if (client == null && IsClientValid)
            {
                NewClient.CompanyId = SelectedCompany.CompanyId;
                // add the new client
                db.Clients.Add(NewClient);

                db.SaveChanges();
                NewClient = new Client();
                refreshCs_E(null);
                // show messagebox to alert success;
                MessageBox.Show("Client Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (client != null)
            {
                Error = this["duplicate"];
            }
            else if (!IsClientValid)
                return;
            else
                MessageBox.Show("Failed to Add Client", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        

        private bool saveCs_C(object obj)
        {
            if (edited == false)
                return false;
            else
            {
                edited = false;
                return true;
            }

        }

        private void saveCs_E(object obj)
        {
            db.SaveChanges();
        }

        private bool delete_C(object obj)
        {
            if (allClientsSelectedId == null || allClientsSelectedId < 0)
                return false;
            else
                return true;
        }

        private  void delete_E(object obj)
        {
            try
            {

                if (allClientsSelectedId == null || allClientsSelectedId < 0)
                {
                    MessageBox.Show("Please select a client to delete");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected Client", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Client client = db.Clients.Find(allClientsSelectedId);
                    db.Clients.Remove(client);
                   
                    db.SaveChanges();
                    refreshCs_E(null);
                }
                
            }
            catch 
            {

            }
        }
        #endregion


        #region Methods

        public bool ValidateNewClient(Client client)
        {
           if(string.IsNullOrWhiteSpace(client.Name) || string.IsNullOrEmpty(client.Address) || string.IsNullOrEmpty(client.City) 
                || string.IsNullOrEmpty(client.Phone) || string.IsNullOrEmpty(client.Email) )
            {
                Error = this["NewClient"];
                return false;
            }
         
            Error = null;
            return true;
           
        }


        public async void SearchClient()
        {
            ObservableCollection<Client> searchedClients = new ObservableCollection<Client>(db.Clients.Where(i=>i.CompanyId == SelectedCompany.CompanyId));

            await Task.Run(() =>
            {
                if (SearchBy == "Name")
                    searchedClients = new ObservableCollection<Client>(db.Clients.Where(i => i.Name.ToLower() == SearchString.ToLower()));
                else if (SearchBy == "Email")
                    searchedClients = new ObservableCollection<Client>(AllClients.Where(i => i.Email.ToLower() == SearchString.ToLower()));
            });
           
            AllClients = searchedClients;
        }


        
        #endregion
    }
}
