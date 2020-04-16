using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.Pages;
using ShortBody.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public  class DashBoardViewModel :ObservableObject
    {
        public static event EventHandler clientChanged;
        public static event EventHandler<DashBoardEventArgs> PageChanged;
       
        public   AppContext db;
        #region PrivateProperties
        
        private DashBoardPages dashboardPages;
        public static  ObservableCollection<Client> allClients;
        public static  ObservableCollection<Supplier> allSuppliers;
        private object logo;
        protected bool edited;
        private Company selectedCompany;
        private string companyName;
        private SynchronizationContext currentContext = SynchronizationContext.Current;
        private User currentUser;
        #endregion

        #region PublicProperties



        public static DashBoardPages dbPage
        {
            set
            {
                OnPageChanged(new DashBoardEventArgs(value));
            }
        }
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

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value;OnPropertyChanged(); }
        }
        public Company SelectedCompany
        {
            get { return selectedCompany;
            }
            set
            {
                selectedCompany = value;
                OnPropertyChanged();
            }
        }

        public object Logo
        {
            get { return logo; }
            set { logo = value; OnPropertyChanged(); }
        }

        public RelayCommand RefreshAllClients { get; set; }
        public  ObservableCollection<Client> AllClients
        {
            get
            {
                return allClients;
            }
            set
            {
                allClients = value;
                edited = true;
               OnClientChanged();
                OnPropertyChanged();
            }
        }


        public ObservableCollection<Supplier> AllSuppliers
        {
            get
            {
                return allSuppliers;
            }
            set
            {
                allSuppliers = value;
                edited = true;
                OnPropertyChanged();
            }
        }


    

        public  DashBoardPages DashBoardPage
        {
            get
            {
                return dashboardPages;

            }
            set
            {
                dashboardPages = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand OpenClients { get; set; }

        public RelayCommand OpenInvoice { get; set; }
        public RelayCommand OpenQuotation { get; set; }
        public RelayCommand OpenSuppliers { get; set; }
        public RelayCommand OpenEspenses { get; set; }

        public RelayCommand OpenIncome { get; set; }

        public RelayCommand OpenPaymentAdvice { get; set; }
        
        public RelayCommand OpenCompanies { get;  set; }
        public RelayCommand OpenUsers { get;  set; }

        public RelayCommand LogoutCommand { get; set; }

        #endregion


        public DashBoardViewModel()
        {
            PageChanged += DashBoardViewModel_PageChanged;
           
            try
            {
                
                db = MainWindowViewModel.db;
                
                //set the current company as the first on in the company list
                //Change this later
            
                if (MainWindowViewModel.selectedCompany != null)//currentCompany != null
                {
                   
                    OpenCompanies = new RelayCommand(this.oCompanies_E, this.Generic_C);
                    SelectedCompany = MainWindowViewModel.selectedCompany;
                    CurrentUser = MainWindowViewModel.currentUser;
                    CompanyName = SelectedCompany.Name;
                    OpenClients = new RelayCommand(this.OpenClients_E, this.Generic_C);
                    OpenInvoice = new RelayCommand(this.OpenInvoice_E, this.Generic_C);
                    OpenQuotation = new RelayCommand(this.OpenQuotation_E, this.Generic_C);
                    OpenSuppliers = new RelayCommand(this.OpenSuppliers_E, this.Generic_C);
                    OpenEspenses = new RelayCommand(this.OpenEspenses_E, this.Generic_C);
                    OpenIncome = new RelayCommand(this.OpenIncome_E, this.Generic_C);
                    OpenPaymentAdvice = new RelayCommand(OpenPaymentAdvice_E, Generic_C);
                    RefreshAllClients = new RelayCommand(this.refreshCs_E, this.refreshCs_C);
                    LogoutCommand = new RelayCommand(t => {

                        if(MessageBox.Show("Are you sure you want to log out of the Application","Confirm Logout",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            LoginPage.IsLoggedOut = true;
                            MainWindowViewModel._CurrentPage = ApplicationPage.Login;
                        }
                    } );
                    OpenUsers = new RelayCommand(oUsers_E, Generic_C);
                    try
                    {
                        AllClients = new ObservableCollection<Client>(SelectedCompany.Clients);
                    }
                    catch { }
                    try
                    {
                        AllSuppliers = new ObservableCollection<Supplier>(SelectedCompany.Suppliers);
                    }
                    catch { }
                    //GetLogo(SelectedCompany.Logo);
                    Logo = SelectedCompany.Logo;
                }
                else
                {
                    MessageBox.Show("Please Select a Company", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    MainWindowViewModel.currentPage = ApplicationPage.Login;
                }

            }
            catch
            {
               // MessageBox.Show("");
            }
           
        }

       

        private void OpenPaymentAdvice_E(object obj)
        {
            DashBoardPage = DashBoardPages.PaymentAdvicePage;
        }

        private void DashBoardViewModel_PageChanged(object sender, DashBoardEventArgs e)
        {
            DashBoardPage = e.Page;
        }

        private void oUsers_E(object obj)
        {
            //currentContext.Post(_ =>
            //{
            //    new MasterPasswordWindow(DashBoardPages.UsersPage).ShowDialog();
            //}, null);
        }

        private bool oUser_C(object obj)
        {
            return true;
        }

        private void oCompanies_E(object obj)
        {
            //currentContext.Post(_ =>
            //{
            //    new MasterPasswordWindow(DashBoardPages.CompaniesPage).ShowDialog();
            //}, null);
         
          //  DashBoardPage = DashBoardPages.CompaniesPage;
        }

   

        #region CommandMethods

        public bool refreshCs_C(object obj)
        {
            return true;
        }

        public void refreshCs_E(object obj)
        {
            db.SaveChanges();
           
            AllClients = new ObservableCollection<Client>(SelectedCompany.Clients);
        }

        #region sideNavCommands

        #region Executes

        private void OpenInvoice_E(object obj)
        {
            DashBoardPage = DashBoardPages.InvoicePage;
        }
        public void OpenClients_E(object parameter)
        {
            DashBoardPage = DashBoardPages.clientPage;
        }

        private void OpenIncome_E(object obj)
        {
            DashBoardPage = DashBoardPages.IncomePage;
        }

        private void OpenEspenses_E(object obj)
        {
           
            DashBoardPage = DashBoardPages.EspensePage;
        }

        private void OpenSuppliers_E(object obj)
        {
            DashBoardPage = DashBoardPages.SuppliersPage;
        }

        private void OpenQuotation_E(object obj)
        {
            DashBoardPage = DashBoardPages.QuotationPage;
        }


        #endregion

        #region Canexecutes

        public bool Generic_C(object parameter)
        {
            return true;
        }
        private bool OpenIncome_C(object obj)
        {
            return true;
        }

        private bool OpenEspenses_C(object obj)
        {
            return true;
        }

        private bool OpenSupplierss_C(object obj)
        {
            return true;
        }

        private bool OpenQuotation_C(object obj)
        {
            return true;
        }

        private bool OpenInvoice_C(object obj)
        {
            return true;
        }
        #endregion


        #endregion

        #endregion


        #region eventMethod
        protected void OnClientChanged()
        {
            clientChanged?.Invoke(this, null);
        }

        #endregion



        #region HelperMethods

        private void GetLogo(byte[] imgbytes)
        {
           
            //var task =  GetBitmap(imgbytes);
           
            //task.ContinueWith(t =>
            //{
            //    Logo = t.Result;
            //},TaskScheduler.FromCurrentSynchronizationContext());
             


        }


        //public async static Task<BitmapImage> GetBitmap(byte[] imgbytes)
        //{

        //    try
        //    {
        //        BitmapImage bi = new BitmapImage();
        //        //Store binary data read from the database in a byte array
        //        byte[] logo = imgbytes;
        //        MemoryStream stream = new MemoryStream();
        //        stream.Write(logo, 0, logo.Length);
        //        stream.Position = 0;

        //        System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
        //        bi = new BitmapImage();
        //        bi.BeginInit();

        //        MemoryStream ms = new MemoryStream();
        //        img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
        //        ms.Seek(0, SeekOrigin.Begin);
        //        bi.StreamSource = ms;
        //        bi.EndInit();
        //        return bi;
        //    }
        //    catch { return null; }

        //    //});
        //}

        public void SaveSearch(ref AppContext adb)
        {
            var quot = adb.Quotations.ToList();
            var vmquot = db.Quotations;
            for (int i = 0; i < db.Quotations.Count(); i++)
            {
                if (quot[i].Client != null)
                {
                    int id = quot[i].QuotationId;
                    var m = db.Quotations.Where(j => j.QuotationId == id).FirstOrDefault();
                    var n = quot[i];
                    AssignQuotationValues(ref m, ref n);

                }
            }

            db.SaveChanges();
            adb = null;
        }

        public void AssignQuotationValues(ref Quotation quot, ref Quotation item)
        {
            quot.QuotationId = item.QuotationId;
            quot.QuoteDate = item.QuoteDate;
            quot.QuoteNumber = item.QuoteNumber;
            quot.QuoteTerms = item.QuoteTerms;
            quot.Remarks = item.Remarks;
            quot.Requester = item.Requester;
            quot.ServiceWanted = item.ServiceWanted;
            quot.TotalAmount = item.TotalAmount;
            quot.VatValue = item.VatValue;
            quot.Vat_Nhil = item.Vat_Nhil;
            quot.WOD = item.WOD;
            quot.Amount = item.Amount;
            quot.IssuedBy = item.IssuedBy;
            quot.JobStatus = item.JobStatus;
            quot.ProjectSite = item.ProjectSite;
        }




        public void DeleteAssociations<T>(DbSet<T> mainSet, IQueryable<T> items)
            where T : class,new ()
        {
            mainSet.RemoveRange(items);
            db.SaveChanges();
        }

        protected static void OnPageChanged(DashBoardEventArgs e)
        {
            PageChanged?.Invoke(null, e);
        }

      

        #endregion
    }

    public class DashBoardEventArgs : EventArgs
    {
        public DashBoardPages Page { get; set; }

        public DashBoardEventArgs(DashBoardPages page)
        {
            Page = page;
        }


    }

   
}
