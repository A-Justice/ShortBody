using ShortBody.Enums;
using ShortBody.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public static event EventHandler<PageChangedEventArgs> _CurrentPageChanged;

        #region PrivateProperties
        private string companyName;
        private string userName;
     
        private string password;
        public static ApplicationPage currentPage;
        public ObservableCollection<Company> companies;
        #endregion

        #region PublicProperties
        public static AppContext db;
        public static Company  selectedCompany;
        public static User currentUser;


        public ObservableCollection<Company> Companies
        {
            get { return companies; }
            set { companies = value; OnPropertyChanged(); }
        }
        public RelayCommand LoginCommand { get; set; }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value;OnPropertyChanged(); }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }

        public static ApplicationPage _CurrentPage
        {
            set
            {
                OnCurrentPageChanged(new PageChangedEventArgs(value));
            }
        }
        public ApplicationPage CurrentPage {
            get { return currentPage; }
            set { currentPage = value;
                OnPropertyChanged(); }
        }

        public  Company SelectedCompany
        {
            get { return selectedCompany; }
            set
            {
                selectedCompany = value;
                if(selectedCompany!=null)
                CompanyName = selectedCompany.Name;
                OnPropertyChanged();
            }
        }

        //Hold the value of the logged in user
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                OnPropertyChanged();
            }
        }

        #endregion
        //private MainWindow mainWindow;

        public MainWindowViewModel()
        {
            //  mainWindow = window;
            db = new AppContext();
            try
            {
                if (db.Companies.Where(i => i.Name == "Default").FirstOrDefault() == null)
                {
                    db.Companies.Add(new Company
                    {
                        Name = "Default",
                        Email = "Default@root.com",
                        Phone = "00000",
                        Address = "#Self",

                    });

                    db.Users.Add(new User
                    {
                        FirstName = "default",
                        LastName = "",
                        Password = "root"
                    });

                    db.MasterPasswords.Add(new MasterPassword()
                    {
                        Password = "root"
                    });


                    db.SaveChanges();
                }
            }
            catch { }
           

           // LoadCompanies();
            LoginCommand = new RelayCommand(Login_E, Login_C);
            CurrentPage = ApplicationPage.Login;
            _CurrentPageChanged += CurrentPage_Changed;
            
        }

        #region EventMethods

        protected static void OnCurrentPageChanged(PageChangedEventArgs e)
        {
            _CurrentPageChanged?.Invoke(null, e);
        }
        private  void CurrentPage_Changed(object sender,PageChangedEventArgs e)
        {
            CurrentPage = e.page;
        }

        #endregion

        private void Login_E(object obj)
        {
            try
            {
                CurrentUser = db.Users.Where(i => i.FirstName == UserName  && i.Password == Password).FirstOrDefault();
                if (CurrentUser != null && SelectedCompany!=null)
                {
                    
                    CurrentPage = ApplicationPage.DashBoard;

                }
                else if(CurrentUser == null)
                {
                   // CurrentPage = ApplicationPage.DashBoard;
                    MessageBox.Show("Please Enter a valid UserName and Password", "Invalid Credentials", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if(SelectedCompany == null)
                {
                    MessageBox.Show("Please select a company to continue", "Select Company", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch { }
            
           
        }

        private bool Login_C(object obj)
        {
            return true;
        }


        #region CommandMethods



        #endregion


        public  void LoadCompanies()
        {
            Companies = new ObservableCollection<Company>(db.Companies);
        }

        public void ResetCredentials()
        {
            selectedCompany = null;
            UserName = null;
            Password = null;
        }
    }

 

    public class PageChangedEventArgs : EventArgs
    {
        public ApplicationPage page;
        public PageChangedEventArgs(ApplicationPage _page)
        {
            page = _page;
        }
    }


   
}
