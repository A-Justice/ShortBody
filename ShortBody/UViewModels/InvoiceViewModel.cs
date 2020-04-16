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
    public class InvoiceViewModel : DashBoardViewModel,IDataErrorInfo
    {


        #region privateVariables

        private string invoiceFor;
        private string searchBy;
        private string searchString;
        // Use the client invoice as a helper to interface bothe the client and supplier invoices
        private ClientInvoice invoiceHelper;
       
        private object _for;
        private object currentFor;
        public AppContext db1;


        #endregion

        #region publicVariables
        public int? CurrentSelectedId = -1;
        public int? selectedInvoiceId = -1;
        private string error;
        private object invoices;
        private object invoices_s;

        #endregion

        #region PublicProperties
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
        //The command that allows to view only the invoice of the selected client or
        //supplier
        public RelayCommand ViewInvoice { get; set; }

        //Holds the new Invoice to be added to the database
        public ClientInvoice InvoiceHelper
        {
            get
            {
                return invoiceHelper;
            }
                set
            {
                invoiceHelper = value;
                OnPropertyChanged(); 
            }
        }


        // The Value of the combo box the shows whether to view Invoices for
        // suppliers or clients
        public string InvoiceFor
        {
            get
            {
                return invoiceFor;
            }
            set
            {
                if (db1 != null)
                    SaveSearch(ref db1);

                invoiceFor = value;
                 ResetInvoiceFor();
                
               // SetCurrentSupplierOrClient();
                OnPropertyChanged();
            }
        }

        // The List of Clients Or Suppliers available in the system
        public object For
        {
            get
            {
                return _for;
            }
            set
            {
                _for = value;
                Error = "";
                OnPropertyChanged();
            }
        }

        // The current client or supplier chosen in the grid
        public object CurrentFor
        {
            get
            {
                return currentFor;
            }
            set
            {
                currentFor = value;
              
                OnPropertyChanged();

                NameForCurrent = ((dynamic)currentFor)?.Name;
            }
        }

        // the Name for the current client or supplier 
        public string NameForCurrent
        {
            get
            {

                if (CurrentFor!=null)
                return ((dynamic)CurrentFor).Name;

                return null;
            }
            set
            {
                OnPropertyChanged();
            }
        }

        // The list of all suppliers in the database
        public object Invoices
        {
            get { return invoices; }
           set{ invoices = value;OnPropertyChanged(); }
        }


        //This holds all original non filterble invoices
        public object InvoicesShadow
        {
            get { return invoices_s; }
            set { invoices_s = value; OnPropertyChanged(); }
        }


        #endregion

        #region CommandProperties

        public RelayCommand AddInvoiceCommand { get; set; }
        public RelayCommand SaveInvoice { get; set; }

        public RelayCommand DeleteInvoiceCommand { get; set; }

        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand ClearCommand { get;  set; }
        public RelayCommand ShowAllInvoices { get;  set; }
        public RelayCommand SearchInvoiceCommand { get; private set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "CurrentFor")
                {
                    return "Please provide a value for all fields";
                }
              
               
                return null;
            }
        }

        #endregion

        public InvoiceViewModel()
        {
            AddInvoiceCommand = new RelayCommand(AddInvoice_E, AddInvoice_C);
            SaveInvoice = new RelayCommand(SaveInvoice_E, SaveInvoice_C);
            InvoiceHelper = new ClientInvoice();
            DeleteInvoiceCommand = new RelayCommand(deleteInvoice_E, deleteInvoice_C);
            ClearCommand = new RelayCommand(Clear_E);
            //subscribe an event to be handled when ever the client list changes
            clientChanged += InvoiceViewModel_clientChanged;
            
            ViewInvoice = new RelayCommand(null, AddInvoice_C);
            ShowAllInvoices = new RelayCommand(null, ShowAllInvoice_C);
            SearchInvoiceCommand = new RelayCommand(_ =>
            {
                if (invoiceFor == "Clients")
                {
                    if (db1 != null)
                        SaveSearch(ref db1);
                    else
                        db.SaveChanges();

                    db1 = new AppContext();
                    SearchInvoice(db1.Clients.Where(i=>i.CompanyId ==SelectedCompany.CompanyId).ToList(),
                        new AppContext().Clients.Where(i => i.CompanyId == SelectedCompany.CompanyId).ToList());
                   
                }
                else if (invoiceFor == "Suppliers")
                {
                    if (db1 != null)
                        SaveSearch(ref db1);
                    else
                        db.SaveChanges();

                    db1 = new AppContext();
                    SearchInvoice(db1.Suppliers.Where(i => i.CompanyId == SelectedCompany.CompanyId).ToList(),
                        new AppContext().Suppliers.Where(i => i.CompanyId == SelectedCompany.CompanyId).ToList());
                }
            });
        }

        private bool ShowAllInvoice_C(object obj)
        {
            if (InvoiceFor != null)
                return true;

            return false;
        }

        private void Clear_E(object obj)
        {
            InvoiceHelper = new ClientInvoice();
        }


        #region EventMethods
        private void InvoiceViewModel_clientChanged(object sender, EventArgs e)
        {
            InvoiceFor = invoiceFor;
        }

        #endregion


        #region CommandMethods


        // Command method executed when ever a sigle clients or suppliers invoice 
        //is to be viewed;
        public void ViewInvoice_E(object obj)
        {
          
                if (invoiceFor == "Clients")
                {
                    invoices = new ObservableCollection<ClientInvoice>(db.Clients.Find(CurrentSelectedId).Invoices);
                invoices_s = new ObservableCollection<ClientInvoice>(db.Clients.Find(CurrentSelectedId).Invoices);
                }
                else if (invoiceFor == "Suppliers")
                {
                    invoices = new ObservableCollection<SupplierInvoice>(db.Suppliers.Find(CurrentSelectedId).Invoices);
                invoices_s = new ObservableCollection<SupplierInvoice>(db.Suppliers.Find(CurrentSelectedId).Invoices);
            }
           


        }


        private void SaveInvoice_E(object obj)
        {
           

            if (invoiceFor == "Clients")
            {
                if (CurrentSelectedId < 1)
                {
                    MessageBox.Show("Select a Client to add Invoice for");
                    return;
                }
    
                    // create the temp invoice that would be saved in the database
                    ClientInvoice tempInvoice = (ShapeInvoice<ClientInvoice>() as ClientInvoice);

              


              

                bool IsInvoiceValid = ValidateInvoice((dynamic)tempInvoice);
                if (/*ti == null && */IsInvoiceValid)
                {

                    db.ClientInvoices.Add(tempInvoice);
                    db.SaveChanges();
                    InvoiceHelper = new ClientInvoice();
                    refreshCs_E(null);
                    // show messagebox to alert success;
                    MessageBox.Show("Client Invoice Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else if (!IsInvoiceValid)
                    return;
             

                MessageBox.Show("An Error occured while adding client invoice", "Failed !! ", MessageBoxButton.OK, MessageBoxImage.Error);

               

            }

            else if (invoiceFor == "Suppliers")
            {
                if (CurrentSelectedId < 1)
                {
                    MessageBox.Show("Select a Supplier to add Invoice for");

                    return;
                }
                SupplierInvoice tempInvoice = (ShapeInvoice<SupplierInvoice>() as SupplierInvoice);
                // Check whether this invoice has already been added

                SupplierInvoice ti;
                try
                {
                     ti = db.SupplierInvoices.Where(i => i.PurchaseOrder_No == tempInvoice.PurchaseOrder_No &&
                       i.ProjectSite == tempInvoice.ProjectSite && i.WayBill_No == tempInvoice.WayBill_No && i.Description == tempInvoice.Description
                      && i.Amount == tempInvoice.Amount && i.Vat_Nhil == tempInvoice.Vat_Nhil && i.Remarks == tempInvoice.Remarks).FirstOrDefault();

                }
                catch {return; }


                if (ti == null && ValidateInvoice((dynamic)tempInvoice))
                {

                    db.SupplierInvoices.Add(tempInvoice);
                    db.SaveChanges();
                    InvoiceHelper = new ClientInvoice();
                    refreshCs_E(null);
                    // show messagebox to alert success;
                    MessageBox.Show("Supplier's Invoice Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                
                MessageBox.Show("An Error occured while adding the Supplier's invoice", "Failed !! ", MessageBoxButton.OK, MessageBoxImage.Error);

            }
                
        }

        public new void refreshCs_E(object obj)
        {
            db.SaveChanges();
            if (invoiceFor == "Clients")
                AllClients = new ObservableCollection<Client>(SelectedCompany.Clients);
            else if (invoiceFor == "Suppliers")
                AllSuppliers = new ObservableCollection<Supplier>(SelectedCompany.Suppliers);

            InvoiceFor = invoiceFor;
        }

        private bool SaveInvoice_C(object obj)
        {
            return true;
        }

        private void AddInvoice_E(object obj)
        {
            //SetCurrentSupplierOrClient();
        }

        private bool AddInvoice_C(object obj)
        {
           
           if(!(CurrentSelectedId > -1))
            {
                return false;
            }
            return true;
        }


        private bool deleteInvoice_C(object obj)
        {
            if (selectedInvoiceId == null || selectedInvoiceId < 0)
                return false;
            else
                return true;
        }

        private void deleteInvoice_E(object obj)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected Invoice", "Confirm delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {

                    if (selectedInvoiceId == null || selectedInvoiceId < 0)
                        return;
                    if (invoiceFor == "Clients")
                    {
                        ClientInvoice iv = db.ClientInvoices.Find(selectedInvoiceId);

                        db.Clients.Find(CurrentSelectedId).Invoices.Remove(iv);
                        db.ClientInvoices.Remove(iv);

                        AllClients.Where(i => i.ClientId == CurrentSelectedId).First().Invoices.Remove(iv);
                    }

                    else if (invoiceFor == "Suppliers")
                    {
                        SupplierInvoice iv = db.SupplierInvoices.Find(selectedInvoiceId);

                        db.Suppliers.Find(CurrentSelectedId).Invoices.Remove(iv);
                        db.SupplierInvoices.Remove(iv);

                        AllSuppliers.Where(i => i.SupplierId == CurrentSelectedId).First().Invoices.Remove(iv);
                    }

                   
                    db.SaveChanges();
                    refreshCs_E(null);
                    selectedInvoiceId = -1;
                }
                catch 
                {
                    MessageBox.Show("Unable to Delete Invoice", "Deletion Failed", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
          
        }

        #endregion


        #region helperMethods

        // Reloads all clients and invoices based on the current selected
        //invoice for
        public void ResetInvoiceFor()
        {
           
                if (invoiceFor == "Clients")
                {

                    For = AllClients;
                    invoices = new ObservableCollection<ClientInvoice>(db.ClientInvoices.Where(i => i.supplier.CompanyId == SelectedCompany.CompanyId));
                    invoices_s = new ObservableCollection<ClientInvoice>(db.ClientInvoices.Where(i => i.supplier.CompanyId == SelectedCompany.CompanyId));
            }
                else if (invoiceFor == "Suppliers")
                {
                    For = AllSuppliers;
                    invoices = new ObservableCollection<SupplierInvoice>(db.SupplierInvoices.Where(i => i.supplier.CompanyId == SelectedCompany.CompanyId));
                   invoices_s = new ObservableCollection<SupplierInvoice>(db.SupplierInvoices.Where(i => i.supplier.CompanyId == SelectedCompany.CompanyId));
            }
         


        }
       
        public void SetCurrentSupplierOrClient()
        {
            if (invoiceFor == "Clients")
            {                
                CurrentFor = db.Clients.Find(CurrentSelectedId);
            }
            else if (invoiceFor == "Suppliers")
            {
                CurrentFor = db.Suppliers.Find(CurrentSelectedId);
            }
               
        }


        /// <summary>
        /// Determines the current invoice to display based on the 
        /// current selected client
        /// </summary>
        /// <typeparam name="T">T is Either a client Invoice or a supplier Invoice</typeparam>
        /// <returns></returns>
        public T ShapeInvoice<T> ()
            where T : class,new()
        {

            try
            {
                if (invoiceFor == "Clients")
                {
                    //invoiceHelper.ClientId = (currentFor as Client).ClientId;
                    invoiceHelper.Date = DateTime.Now;
                    invoiceHelper.ClientId = (currentFor as Client).ClientId;
                    invoiceHelper.VatValue = ((invoiceHelper.Vat_Nhil / 100) * invoiceHelper.Amount);
                    invoiceHelper.TotalAmount = invoiceHelper.Amount + invoiceHelper.VatValue;
                    // invoiceHelper.Invoice_No = GetInvoiceNumber();

                    if (CheckDuplicateInvoiceNumber(invoiceHelper.Invoice_No) == false)
                        return null;

                    return invoiceHelper as T;
                }

                else if (invoiceFor == "Suppliers")
                {
                    // the original invoice return;
                    SupplierInvoice ci = new SupplierInvoice();

                    //


                    ci.Date = DateTime.Now;
                    ci.PurchaseOrder_No = invoiceHelper.PurchaseOrder_No;
                    ci.ProjectSite = invoiceHelper.ProjectSite;
                    ci.WayBill_No = invoiceHelper.WayBill_No;
                    ci.Description = invoiceHelper.Description;
                    ci.Amount = invoiceHelper.Amount;
                    ci.Vat_Nhil = invoiceHelper.Vat_Nhil;
                    ci.Remarks = invoiceHelper.Remarks;
                    ci.SupplierId = (CurrentFor as Supplier).SupplierId;

                    ci.VatValue = ((ci.Vat_Nhil / 100) * ci.Amount);
                    ci.TotalAmount = ci.Amount + ci.VatValue;
                    ci.Invoice_No = invoiceHelper.Invoice_No;

                    if (CheckDuplicateInvoiceNumber(ci.Invoice_No) == false)
                        return null;

                    return ci as T;
                }
            }
            catch { return null; }


            return null;
          
        }

        public bool ValidateInvoice(dynamic currentFor)
        {
            if (currentFor == null)
                return false;

            if (currentFor.PurchaseOrder_No == null || currentFor.ProjectSite == null || currentFor.WayBill_No == null || currentFor.Description == null
                 || currentFor.Amount == null || currentFor.Vat_Nhil == null || currentFor.Remarks == null)
            {
                Error = this["CurrentFor"];
                return false;
            }

            Error = null;
            return true;
        }



        /// <summary>
        /// This method checks if there is any duplicate invoice number in the system 
        /// an prompts the user
        /// </summary>
        /// <param name="Number">the Current invoice number to be checked against 
        /// those already int the system</param>
        /// <returns>Returns true if everything is gud to continue</returns>
        private bool CheckDuplicateInvoiceNumber(string Number)
        {
            if(db.ClientInvoices.Where(i=>i.Invoice_No ==Number && i.supplier.CompanyId == SelectedCompany.CompanyId).FirstOrDefault() != null)
            {
              MessageBoxResult r =   MessageBox.Show("An Invoice With the same number already exists , do you want to add it anyway","Conflicting Invoice Numbers",MessageBoxButton.YesNo,MessageBoxImage.Information);
                if (r == MessageBoxResult.Yes)
                    return true;
                else
                    return false;
            }
            return true;
           
        }

        //
        public async void SearchInvoice<T>(List<T> ListItems,List<T> AdListItems) 
            where T:class,new()
        {
            if (SearchBy == "All")
            {
                For = new ObservableCollection<T>(ListItems);
                return;
            }
            else if (SearchBy == null)
                return;
             

            ObservableCollection<T> filteredClients = new ObservableCollection<T>(ListItems);
            List<T> AdhocClients = new List<T>(AdListItems);

            await Task.Run(() =>
            {
                int x = 0; // keep count of the current client
                int clientsDeleted = 0;
                (AdhocClients).ForEach(i =>
                {
                    int invoicesDeleted = 0;
                    bool IsPart = false;
                    var dynamicInvoice = ((dynamic)i).Invoices;
                    for (int a = 0; a < dynamicInvoice.Count; a++)
                    {
                        bool isResult = false;
                        bool IsMatch = false;
                        switch (SearchBy)
                        {
                            case "Invoice #":
                                IsMatch = dynamicInvoice[a].Invoice_No.ToLower() == SearchString.ToLower();
                                break;
                            case "Remarks":
                                IsMatch = dynamicInvoice[a].Remarks.ToLower() == SearchString.ToLower();
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
                        if (!isResult && ((dynamic)filteredClients[x]).Invoices.Count>0)
                        {
                            
                            ((dynamic)filteredClients[x]).Invoices.RemoveAt(a - invoicesDeleted);
                            invoicesDeleted++;
                        }
                    }
                    if (!IsPart && ((dynamic)filteredClients).Count>0)
                    {
                        ((dynamic)filteredClients).RemoveAt(x - clientsDeleted);
                        clientsDeleted++;

                    }

                    x++;
                });

            });
          
            For = new ObservableCollection<T>(filteredClients);
        }


        public void SaveSearch(ref AppContext abstractdb)
        {
            if(invoiceFor == "Clients")
            {
                var invoice = abstractdb.ClientInvoices.ToList();
                var vmquot = db.ClientInvoices;
                for (int i = 0; i < vmquot.Count(); i++)
                {
                    if (invoice[i].supplier != null)
                    {
                        int id = invoice[i].ClientInvoiceId;
                        var m = db.ClientInvoices.Where(j => j.ClientInvoiceId == id).FirstOrDefault();
                        var n = invoice[i];
                        AssignInvoiceValues(ref m, ref n);

                    }
                }
            }
            else if(invoiceFor == "Suppliers")
            {
                var invoice = abstractdb.SupplierInvoices.ToList();
                var vmquot = db.SupplierInvoices;
                for (int i = 0; i < vmquot.Count(); i++)
                {
                    if (invoice[i].supplier != null)
                    {
                        int id = invoice[i].SupplierInvoiceId;
                        var m = db.SupplierInvoices.Where(j => j.SupplierInvoiceId == id).FirstOrDefault();
                        var n = invoice[i];
                        AssignInvoiceValues(ref m, ref n);

                    }
                }
            }
           

            db.SaveChanges();
            abstractdb = null;
        }

        void AssignInvoiceValues(ref ClientInvoice inv, ref ClientInvoice item)
        {
            inv.Invoice_No = item.Invoice_No;
            inv.Date = item.Date;
            inv.PurchaseOrder_No = item.PurchaseOrder_No;
            inv.ProjectSite = item.ProjectSite;
            inv.WayBill_No = item.WayBill_No;
            inv.Description = item.Description;
            inv.Amount = item.Amount;
            inv.Vat_Nhil = item.Vat_Nhil;
            inv.VatValue = item.VatValue;
            inv.TotalAmount = item.TotalAmount;
            inv.Remarks = item.Remarks;
        }

        void AssignInvoiceValues(ref SupplierInvoice inv, ref SupplierInvoice item)
        {
            inv.Invoice_No = item.Invoice_No;
            inv.Date = item.Date;
            inv.PurchaseOrder_No = item.PurchaseOrder_No;
            inv.ProjectSite = item.ProjectSite;
            inv.WayBill_No = item.WayBill_No;
            inv.Description = item.Description;
            inv.Amount = item.Amount;
            inv.Vat_Nhil = item.Vat_Nhil;
            inv.VatValue = item.VatValue;
            inv.TotalAmount = item.TotalAmount;
            inv.Remarks = item.Remarks;
        }
        #endregion

    }
}
