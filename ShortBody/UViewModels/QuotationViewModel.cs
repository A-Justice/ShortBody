using ShortBody.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class QuotationViewModel :DashBoardViewModel,IDataErrorInfo
    {


        #region privateVariables
        int guildAdder = 0;
        public ManualResetEvent signal = new ManualResetEvent(false);
        private string error;
        private Quotation selectedQuotation;
        private ObservableCollection<Client> clients;
        private string searchBy;
        private string searchString;
        #endregion


        SynchronizationContext currentContext;

        #region publicVariables
        public ObservableCollection<Client> Clients
        {
            get { return clients; }
            set
            {
                clients = value;
                OnPropertyChanged();
            }
        }
        public string SearchBy
        {
            get { return searchBy; }
            set
            {
                searchBy = value;
                OnPropertyChanged();
            }
        }

        public string SearchString
        {
            get { return searchString; }
            set { searchString = value; OnPropertyChanged(); }
        }


        public int accountCounter = 1;
        public int? SelectedItemId;
        public RelayCommand ClientQuotationCommand { get; set; }
        //Holds the quotation  of the currently selected client
        public ObservableCollection<Quotation> clientQuotation;

        //Holds all quotations in the database
        public ObservableCollection<Quotation> allQuotations;

        //Holds the new quotation that is currently being added to 
        //the database
        public Quotation newquotation;
        public Client selectedClient;

        //Account details of the current company
        private CompanyAccountDetail companyAccDetails;

        //Holds the particular quotation to show in the report
        //It is assigned either AllQuotations or ClientQuotation Based on 
        // What user wants
        private ObservableCollection<Quotation> reportedQuotation;

        //selected client id
        public int? allClientsSelectedId { get; set; } = -1;

        // selected quotation id of a specific client
        public int? selectedQuotationId { get; set; }
        #endregion

        #region publicProperties
        public int AccountCounter
        {
            get { return accountCounter; }
            set
            {
                accountCounter = value;
                SetCurrentAccountDetail(accountCounter);
            }
        }
        public RelayCommand DeleteItemCommand { get; set; }
        public Company CurrentCompany { get; set; } = MainWindowViewModel.selectedCompany;

        public ObservableCollection<Quotation> ReportedQuotation
        {
            get
            {
                return reportedQuotation;
            }
            set { reportedQuotation = value; OnPropertyChanged(); }
        }


        public ObservableCollection<Quotation> ClientQuotation
        {
            get
            {
                return clientQuotation;
            }
            set { clientQuotation = value;OnPropertyChanged(); }
        }

        public ObservableCollection<Quotation> AllQuotations
        {
            get
            {
                return allQuotations;
            }
            set { allQuotations = value; OnPropertyChanged(); }
        }

        public Quotation SelectedQuotation
        {
            get {
                return selectedQuotation; }
            set { selectedQuotation = value; OnPropertyChanged(); }
        }


        public CompanyAccountDetail CompanyAccDetails
        {
            get { return companyAccDetails; }
            set { companyAccDetails = value;OnPropertyChanged(); }
        }

        public RelayCommand DeleteQuotationCommand { get; set; }
        public Client SelectedClient
        {
            get
            {
                return selectedClient;
            }
            set
            {
                selectedClient = value;
                OnPropertyChanged();
            }
        }

        public Quotation NewQuotation
        {
            get
            {
                return newquotation;
            }
            set
            {
                newquotation = value;
                newquotation.IssuedBy = CurrentUser.FirstName;
                OnPropertyChanged();
            }
        }

        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                OnPropertyChanged();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewQuotation")
                {
                    return "Please fill the form with appropriate Credentials";
                }
                return null;
            }
         
        }

        public RelayCommand SaveQuotation { get; set; }
       

        public RelayCommand ClearBoxes { get; set; }

        public RelayCommand AddQuotationCommand { get; set; }
        public RelayCommand ViewQuotation { get; set; }
        public RelayCommand SearchQuotationCommand { get; private set; }

        #endregion



        public QuotationViewModel()
        {
            cBoxes_E(null);

            currentContext = SynchronizationContext.Current;
            Clients = AllClients;
            SaveQuotation = new RelayCommand(saveQuot_E, saveQuot_C);
            ClearBoxes = new RelayCommand(cBoxes_E, cBoxes_C);
            AddQuotationCommand = new RelayCommand(AddQuotation_E, AddQuotation_C);
            clientChanged += QuotationViewModel_clientChanged;
            DeleteQuotationCommand = new RelayCommand(deleteQuotation_E, deleteQuotation_C);
            ViewQuotation = new RelayCommand(null, deleteQuotation_C);
            ClientQuotationCommand = new RelayCommand(null, ClientQuotations_C);
            DeleteItemCommand = new RelayCommand(DeleteItem_E, DeleteItem_C);
            CompanyAccDetails = SelectedCompany.AccountDetails?.FirstOrDefault();
            AllQuotations = new ObservableCollection<Quotation>(db.Quotations.Where(i=>i.Client.CompanyId == CurrentCompany.CompanyId));
            SearchQuotationCommand = new RelayCommand(_ =>
            {
                if (DashBoard.db1 != null)
                    SaveSearch(ref DashBoard.db1);
                else
                    db.SaveChanges();

                DashBoard.db1 = new AppContext();
                SearchQuotation(DashBoard.db1.Clients.Where(i => i.CompanyId == SelectedCompany.CompanyId).ToList(), 
                    new AppContext().Clients.Where(i => i.CompanyId == SelectedCompany.CompanyId).ToList());
                
            });
        }

       

        private bool DeleteItem_C(object obj)
        {
            if(SelectedItemId != null)
            return true;

            return false;
        }

        private void DeleteItem_E(object obj)
        {
            try
            {
                if (SelectedItemId != null)
                {
                    //db.SaveChanges();
                    QuotationItem item = db.QuotationItems.Find((int)SelectedItemId);


                  
                    currentContext.Post(t=>
                    {
                        if (item!=null)
                        {
                            db.QuotationItems.Remove(item);
                            selectedQuotation.Items.Remove(item);
                            db.SaveChanges();
                          
                        }
                        signal.Set();
                    },null);
                    
                    signal.WaitOne();
                    selectedQuotation.Items = selectedQuotation.Items;
                    
                }
            }
            catch { }
           
        }


        #region EventMethods

        private void QuotationViewModel_clientChanged(object sender, EventArgs e)
        {
            Clients = AllClients;
            AllQuotations = new ObservableCollection<Quotation>(db.Quotations.Where(i => i.Client.CompanyId == CurrentCompany.CompanyId));
        }

        #endregion


        #region CommandMethods
        private bool deleteQuotation_C(object obj)
        {
            if (selectedQuotationId == null || selectedQuotationId < 0)
                return false;
            else
                return true;
        }

        private bool ClientQuotations_C(object obj)
        {
            if (allClientsSelectedId == null || allClientsSelectedId < 0)
                return false;
            else
                return true;
        }

        private void deleteQuotation_E(object obj)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected Quotation ? ", "Confirm delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {

                    if (selectedQuotationId == null || selectedQuotationId < 0)
                        return;
               
                        Quotation iv = db.Quotations.Find(selectedQuotationId);

                      
                        db.Clients.Find(allClientsSelectedId).Quotations.Remove(iv);
                    db.QuotationItems.RemoveRange(iv.Items);
                     db.Quotations.Remove(iv);
                        Clients.Where(i => i.ClientId == allClientsSelectedId).First().Quotations.Remove(iv);
                    
                    db.SaveChanges();
                    refreshCs_E(null);
                    selectedQuotationId = -1;
                }
                catch 
                {
                    MessageBox.Show("Unable to Delete Quotation", "Deletion Failed", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }

        }

        private void AddQuotation_E(object obj)
        {
            SetSelectedClient();
        }

        private bool AddQuotation_C(object obj)
        {

            if (!(allClientsSelectedId > -1))
            {
                return false;
            }
            return true;
        }

        private async void cBoxes_E(object obj)
        {
            NewQuotation = new Quotation();
            NewQuotation.QuoteNumber = await GetQuotationNumber();
        }

        private bool cBoxes_C(object obj)
        {
            return true;
        }
     
        private async void saveQuot_E(object obj)
        {

            //Check if the client has already been added
            Quotation Quot = db.Quotations.Where(i => i.ProjectSite == NewQuotation.ProjectSite && i.ServiceWanted == NewQuotation.ServiceWanted 
            && i.Vat_Nhil == NewQuotation.Vat_Nhil&&i.Remarks==NewQuotation.Remarks).FirstOrDefault();

            bool IsQuotationValid = ValidateNewQuotation(NewQuotation);

            //Check if there is Duplicate Quotation, alert the user and return
            if (!CheckDuplicateQuotationNumber(NewQuotation.QuoteNumber))
                return;

            if (Quot == null && IsQuotationValid)
            {
                NewQuotation.ClientId = (int)allClientsSelectedId;
                NewQuotation.QuoteDate = DateTime.Now;
                NewQuotation.Remarks = "UnPaid";
                // add the new client
                db.Quotations.Add(NewQuotation);

                db.SaveChanges();
                NewQuotation = new Quotation();
                NewQuotation.QuoteNumber = await GetQuotationNumber();
                refreshCs_E(null);
                AllQuotations = new ObservableCollection<Quotation>(db.Quotations);
                // show messagebox to alert success;
                MessageBox.Show("Client's Quotation Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (!IsQuotationValid)
                return;


            MessageBox.Show("Failed to add client's quotation", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private bool saveQuot_C(object obj)
        {
            return true; 
        }

        #endregion


        #region HelperMethods

        public bool ValidateNewQuotation(Quotation quot)
        {
            if (quot.ProjectSite == null 
               || quot.JobStatus == null || quot.Requester == null || quot.ServiceWanted == null)
            {
                Error = this["NewQuotation"];
                return false;
            }

            Error = null;
            return true;

        }


        public void SetSelectedClient()
        { 
            SelectedClient = db.Clients.Find(allClientsSelectedId);
            clientQuotation = new ObservableCollection<Quotation>(SelectedClient.Quotations);
        }

        // Helps to set the value of the selected Quotation Property
        // when the selected quotation in the grid changes
        public void ChangeSelectedQuotation()
        {
            SelectedQuotation = db.Quotations.Find(selectedQuotationId);
        }

       
        #endregion

        private void SetCurrentAccountDetail(int index)
        {
            int actualIndex = index - 1;
            if(SelectedCompany.AccountDetails.Count> actualIndex && actualIndex >-1)
            CompanyAccDetails = SelectedCompany.AccountDetails.ElementAt(actualIndex);
        }

        private Task<int> GetQuotationNumber()
        {
           

            return Task.Run(() =>
            {
                int quotationNumber = 1000001;
                try
                {
                    if (db.Quotations.Where(i => i.Client.CompanyId == SelectedCompany.CompanyId).Count() == 0)
                        quotationNumber = 100001;
                    else
                    {
                        Quotation lastQuotation = db.Quotations.Where(i => i.Client.CompanyId == SelectedCompany.CompanyId).ToList().Last();
                        quotationNumber = lastQuotation.QuoteNumber + 1;
                    }

                    while (db.Quotations.Where(i => i.QuoteNumber == quotationNumber && i.Client.CompanyId == SelectedCompany.CompanyId).FirstOrDefault() != null)
                    {
                        guildAdder++;
                        quotationNumber += guildAdder;
                    }
                    guildAdder++;
                }
                catch 
                {

                }
                

                
                
               
                return quotationNumber;
            });
        }

        private bool CheckDuplicateQuotationNumber(int Number)
        {
            if (db.Quotations.Where(i => i.QuoteNumber == Number && i.Client.CompanyId == SelectedCompany.CompanyId).FirstOrDefault() != null)
            {
                MessageBoxResult r = MessageBox.Show("A Quotation With the same number already exists , do you want to add it anyway", "Conflicting Quotation Numbers", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (r == MessageBoxResult.Yes)
                    return true;
                else
                    return false;
            }
            return true;

        }

        public async  void SearchQuotation(List<Client> ListItems, List<Client> AdListItems)
        {

            if (SearchBy == "All")
            {
                Clients = new ObservableCollection<Client>(ListItems);
                return;
            }
            ObservableCollection<Client> filteredClients = new ObservableCollection<Client>(ListItems);
            List<Client> AdhocClients = new List<Client>(AdListItems);


            await Task.Run(() => {

                int x = 0; // keep count of the current client
                int clientsDeleted = 0;
                (AdhocClients).ForEach(i =>
                {
                    int quotationsDeleted = 0;
                    bool IsPart = false;
                    var ClientQuotations = i.Quotations;
                    for (int a = 0; a < ClientQuotations.Count; a++)
                    {
                        bool isResult = false;
                        bool IsMatch = false;
                        switch (SearchBy)
                        {
                            case "Quote #":
                                IsMatch = ClientQuotations[a].QuoteNumber.ToString() == SearchString;
                                break;
                            case "Job Status":
                                IsMatch = ClientQuotations[a].JobStatus.ToLower() == SearchString.ToLower();
                                break;
                            case "Remarks":
                                IsMatch = ClientQuotations[a].Remarks.ToLower() == SearchString.ToLower();
                                break;
                            default:
                                IsMatch = false;
                                break;
                        }
                        if (IsMatch)
                        {
                            IsPart = true;
                            isResult = true;
                        }
                        if (!isResult && (filteredClients[x]).Quotations.Count >0)
                        {
                            (filteredClients[x]).Quotations.RemoveAt(a - quotationsDeleted);
                          
                            quotationsDeleted++;
                        }
                    }
                    if (!IsPart && filteredClients.Count>0)
                    {
                        (filteredClients).RemoveAt(x - clientsDeleted);
                        clientsDeleted++;

                    }

                    x++;
                });
            });

            Clients = new ObservableCollection<Client>(filteredClients);
        }


    }
}
