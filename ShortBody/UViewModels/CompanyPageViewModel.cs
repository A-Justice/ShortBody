using Microsoft.Win32;
using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class CompanyPageViewModel : DashBoardViewModel, IDataErrorInfo
    {

        #region privateVariables
        SynchronizationContext currentContext;
        public object logo;
        private string strName;
        private string imagePath;
        private string imageName;
        private Company newCompany;
        private Operation newOperation;
        private CompanyAccountDetail newCompanyAccount;
        private Company focusedCompany;
        private string error;
        private string oerror;
        internal int? allOperationSelectedId;
        internal int? allAccDetailSelectedId;
        private string searchBy;
        private string searchString;
        #endregion

        #region PublicVariables

        public int? allCompanySelectedId { get; internal set; }


        #endregion


        #region publicProperties

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

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Duplicate")
                {
                    return "The Item Already Exists";
                }
                if (columnName == "ProvideValues")
                {
                    return "Please Provide Values for all fields";
                }
                return "";
            }
        }


        public string Error
        {
            get
            {
                return error;
            }
            set
            {
                error = value;
                OnPropertyChanged();
            }

        }

        public string OError
        {
            get { return oerror; }
            set
            {
                oerror = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Company> AllCompanies
        {
            get { return allCompanies; }
            set { allCompanies = value; OnPropertyChanged(); }
        }

        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set { imagePath = value; OnPropertyChanged(); }
        }

        public RelayCommand BrowseCommand { get; set; }

        public RelayCommand SaveCompanyCommand { get; set; }
        public RelayCommand SaveOperationCommand { get; set; }
        public RelayCommand SaveAccountCommand { get; set; }

        public RelayCommand ClearBoxes { get; set; }
        public RelayCommand DeleteCompanyCommand { get; set; }
        public RelayCommand DeleteAccDetailCommand { get; private set; }
        public RelayCommand DeleteOperationCommand { get; private set; }
        public RelayCommand GeneralCommand { get; private set; }


        public Company FocusedCompany
        {
            get
            {
                return focusedCompany;
            }
            set
            {
                focusedCompany = value;
                OnPropertyChanged();
            }
        }


        public new object Logo
        {
            get { return logo; }
            set { logo = value; OnPropertyChanged(); }
        }

        public Company NewCompany
        {
            get
            {
                return newCompany;
            }
            set
            {
                newCompany = value;
                OnPropertyChanged();
            }
        }

        public Operation NewOperation
        {
            get { return newOperation; }
            set { newOperation = value;OnPropertyChanged(); }
        }

        public CompanyAccountDetail NewCompanyAccount
        {
            get { return newCompanyAccount; }
            set { newCompanyAccount = value;OnPropertyChanged(); }
        }

        public RelayCommand SearchCompanyCommand { get; private set; }

        public ObservableCollection<Company> allCompanies;

        #endregion

        
        #region constructor

        public CompanyPageViewModel()
        {
            try
            {
                NewCompany = new Company();
                NewOperation = new Operation();
                NewCompanyAccount = new CompanyAccountDetail();
                BrowseCommand = new RelayCommand(Browse_E, Browse_C);
                SaveCompanyCommand = new RelayCommand(SaveCompany_E, SaveCompany_C);
                SaveOperationCommand = new RelayCommand(SaveOperation_E, SaveOperation_C);
                SaveAccountCommand = new RelayCommand(SaveAccountCommand_E, SaveAccountCommand_C);
                DeleteCompanyCommand = new RelayCommand(DeleteCompany_E,General_C);
                DeleteOperationCommand = new RelayCommand(DeleteOperation_E, DeleteOperation_C);        
                GeneralCommand = new RelayCommand(null, General_C);
                DeleteAccDetailCommand = new RelayCommand(DeleteAccDetail_E, General_C);
                ClearBoxes = new RelayCommand(Clear_E);
                AllCompanies = new ObservableCollection<Company>(db.Companies);
                currentContext = SynchronizationContext.Current;
                SearchCompanyCommand = new RelayCommand(_ =>
                {
                    SearchCompany();
                });
            }
            catch { }
            
        }



        #endregion

        #region CommandMethods

        public new void refreshCs_E(object parameter)
        {
            Logo = null;
            AllCompanies = new ObservableCollection<Company>(db.Companies);
        }

        private void Browse_E(object obj)
        {
            
            try
            {
                imageName = null;
                FileDialog fldlg = new OpenFileDialog();
                fldlg.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                fldlg.ShowDialog();
                {
                    strName = fldlg.SafeFileName;
                    imageName = fldlg.FileName;
                    ImageSourceConverter isc = new ImageSourceConverter();
                    Logo = isc.ConvertFromString(imageName);
                    //  imgBox.SetValue(Image.SourceProperty,);
                }
                fldlg = null;
            }
            catch
            {
                
            }
        }

        private bool Browse_C(object obj)
        {
            return true;
        }


        private bool General_C(object obj)
        {
            if (allCompanySelectedId == null)
                return false;
            return true;
        }


        private bool DeleteOperation_C(object obj)
        {
            if (allOperationSelectedId == null)
                return false;
            return true;
        }

        private void DeleteAccDetail_E(object obj)
        {
            try
            {

                if (allAccDetailSelectedId == null || allAccDetailSelectedId < 0)
                {
                    MessageBox.Show("Please select an Account to delete");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected Account", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var AccDetail = db.CompanyAccountDetails.Find(allAccDetailSelectedId);
                    focusedCompany.AccountDetails.Remove(AccDetail);
                    db.CompanyAccountDetails.Remove(AccDetail);
                    db.SaveChanges();
                    refreshCs_E(null);
                   
                    SetFocusedCompany();
                    var accountdetails = FocusedCompany.AccountDetails;
                    FocusedCompany.AccountDetails = null;
                    FocusedCompany.AccountDetails = accountdetails;
                }

            }
            catch 
            {

            }
        }

        private void DeleteOperation_E(object obj)
        {
            try
            {

                if (allOperationSelectedId == null || allOperationSelectedId < 0)
                {
                    MessageBox.Show("Please select an Operation to delete");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected Operation", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var operation = db.Operations.Find(allOperationSelectedId);
                    FocusedCompany.Operations.Remove(operation);
                    db.Operations.Remove(operation);
                    db.SaveChanges();
                    refreshCs_E(null);
                }

            }
            catch 
            {

            }
        }

        private void DeleteCompany_E(object obj)
        {
            try
            {
                if (allCompanySelectedId == null || allCompanySelectedId < 0)
                {
                    MessageBox.Show("Please select a company to delete");
                    return;
                }

                if (MessageBox.Show("Deleting a Company would also delete all data about the company , Including data of all clients " +
                                    "and suppliers, Click Okay to Proceed", "Permanent Delete Information", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.Cancel)
                    return;

                if(allCompanySelectedId == 1)
                {
                    MessageBox.Show("Default Company Cannot be deleted", "Invalid Operation", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                var company = db.Companies.Find(allCompanySelectedId);
                if (company == SelectedCompany)
                {
                    MessageBox.Show("The Currently Selected Company Cannot be deleted", "Invalid Operation", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                   
                else if (MessageBox.Show("Are you sure you want to delete the selected Company", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    
                    db.Companies.Remove(company);
                    currentContext.Post(_ =>
                    {
                        AllCompanies.Remove(company);
                    }, null);
                 
                    db.SaveChanges();
                    refreshCs_E(null);
                }

            }
            catch 
            {

            }
        }

        private void Clear_E(object parameter)
        {
            NewOperation = new Operation();
            NewCompanyAccount = new CompanyAccountDetail();
            NewCompany = new Company();
        }
        private void SaveOperation_E(object obj)
        {
            try
            {
                var operation = db.Operations.Where(i => i.OperationName == NewOperation.OperationName && i.OperationDescription == NewOperation.OperationDescription && i.EstimateAmount == NewOperation.EstimateAmount).FirstOrDefault();
                bool IsOperationValid = ValidateNewOperation(NewOperation);

                if (operation  == null && IsOperationValid)
                {
                    
                    NewOperation.CompanyId = FocusedCompany.CompanyId;
                    db.Operations.Add(NewOperation);
                    db.SaveChanges();
                    NewOperation = new Operation();
                    refreshCs_E(null);
                    // show messagebox to alert success;
                    MessageBox.Show("Operation Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else if (operation != null)
                {
                    OError = this["Duplicate"];
                }
                if(!IsOperationValid)
                    return;


            }
            catch
            { 
                // show Message Box  to alert failure
                MessageBox.Show("Failed to Add Operation", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidateNewOperation(Operation newOperation)
        {
            if (string.IsNullOrWhiteSpace(newOperation.OperationName) || string.IsNullOrEmpty(newOperation.OperationDescription) || string.IsNullOrEmpty(newOperation.EstimateAmount.ToString()))      
            {
                OError = this["ProvideValues"];
                return false;
            }

            OError = null;
            return true;
        }

        private bool SaveOperation_C(object obj)
        {
            return true;
        }

        private void SaveAccountCommand_E(object obj)
        {
            try
            {
                var account = db.CompanyAccountDetails.Where(i => i.AccountName == NewCompanyAccount.AccountName && i.AccountNumber == NewCompanyAccount.AccountNumber && i.BankBranch == NewCompanyAccount.BankBranch).FirstOrDefault();

                bool IsAccountValid = ValidateAccount(NewCompanyAccount);
                if (account == null && IsAccountValid)
                {
                    
                    NewCompanyAccount.CompanyId = FocusedCompany.CompanyId;
                    focusedCompany.AccountDetails.Add(NewCompanyAccount);
                    db.CompanyAccountDetails.Add(NewCompanyAccount);
                    db.SaveChanges();
                    NewCompanyAccount = new CompanyAccountDetail();
                    refreshCs_E(null);
                    SetFocusedCompany();
                    FocusedCompany.AccountDetails = focusedCompany.AccountDetails;
                    // show messagebox to alert success;
                    MessageBox.Show("Account Detail Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else if(account != null)
                {
                    Error = this["Duplicate"];
                }
                if (!IsAccountValid)
                    return;

               
            }
            catch
            {  // show Message Box  to alert failure
                MessageBox.Show("Failed to add Account detail", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private bool ValidateAccount(CompanyAccountDetail newCompanyAccount)
        {
            if (string.IsNullOrWhiteSpace(newCompanyAccount.AccountName) || string.IsNullOrEmpty(newCompanyAccount.AccountNumber) || string.IsNullOrEmpty(newCompanyAccount.BankName) || string.IsNullOrEmpty(newCompanyAccount.BankBranch)
            )
            {
                Error = this["ProvideValues"];
                return false;
            }

            Error = null;
            return true;
        }

        private bool SaveAccountCommand_C(object obj)
        {
            return true;
        }

        private void SaveCompany_E(object obj)
        {
            //Check if the company has already been added
            var company = db.Companies.Where(i =>i.Name == NewCompany.Name && i.Address ==NewCompany.Address&& i.Email ==NewCompany.Email).FirstOrDefault();
            if (company == null)//&& ValidateNewClient(NewClient)
            {
                
                NewCompany.Logo = GetImageBytes(imageName);
                db.Companies.Add(NewCompany);

                db.SaveChanges();
                NewCompany = new Company();
                refreshCs_E(null);
                // show messagebox to alert success;
                MessageBox.Show("Company Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (company != null)
            {
                Error = this["Duplicate"];
            }
            else
            {
                Error = this["ProvideValues"];
            }

            // show Message Box  to alert failure
            MessageBox.Show("Company to Add Client", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private bool SaveCompany_C(object obj)
        {
            return true;
        }


        #endregion


         public static byte[] GetImageBytes(string imageName)
        {
            try
            {
                byte[] imgByteArr = null;
                try
                {
                    if (imageName != "")
                    {
                        //Initialize a file stream to read the image file
                        FileStream fs = new FileStream(imageName, FileMode.Open, FileAccess.Read);

                        //Initialize a byte array with size of stream
                        imgByteArr = new byte[fs.Length];

                        //Read data from the file stream and put into the byte array
                        fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));

                        //Close a file stream
                        fs.Close();
                    }

                    return imgByteArr ?? null;
                }
                catch 
                {
                    //MessageBox.Show(ex.Message);
                    return null;
                }
            }
            catch { return null; }
           
        }


        /// <summary>
        /// Reset the currently focused company when User Selection Changes
        /// </summary>
        public void SetFocusedCompany()
        { 
                FocusedCompany = db.Companies.Find(allCompanySelectedId);
        }

       
        public void ResetCompanyLogo()
        {
            try
            {
                Browse_E(null);
                FocusedCompany.Logo = GetImageBytes(imageName);
                db.SaveChanges();

                if (MessageBox.Show("Company Image was  changed Successfully,Changes would be applied on next login, Would you like to logout Now ?", "Success", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    LoginPage.IsLoggedOut = true;
                    MainWindowViewModel._CurrentPage = ApplicationPage.Login;
                }

            }
            catch
            {
                MessageBox.Show("Company Image was not changed,retry again later", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public async void SearchCompany()
        {
            ObservableCollection<Company> searchedCompanies = new ObservableCollection<Company>(db.Companies);

            await Task.Run(() =>
            {
                if (SearchBy == "Name")
                    searchedCompanies = new ObservableCollection<Company>(db.Companies.Where(i => i.Name.ToLower() == SearchString.ToLower()));
            });

            AllCompanies = searchedCompanies;
        }

    }
}
