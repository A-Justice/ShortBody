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
    public class SupplierPageViewModel : DashBoardViewModel, IDataErrorInfo
    {


        #region privateVariable
        Supplier newSupplier;
        private string error;
        private string searchBy;
        private string searchString;
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

        public Supplier NewSupplier
        {
            get
            {
                return newSupplier;
            }
            set
            {
                newSupplier = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand DeleteSupplierCommand { get; set; }
        public RelayCommand SaveSuppliersCommand { get; set; }

        public RelayCommand SaveNewSupplierCommand { get; set; }

        public RelayCommand RefreshAllSuppliers { get; set; }

        public int? allSuppliersSelectedId { get; set; }

        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand ClearBoxes { get; set; }
        public RelayCommand SearchSupplierCommand { get; private set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewSupplier")
                {
                    return "Please provide a value for all fields";
                }
                if (columnName == "Duplicate")
                {
                    return "Supplier with the same details already exists";
                }
                return null;
            }
        }
        #endregion

        #region Constructors
        public SupplierPageViewModel()
        {
            newSupplier = new Supplier();
            DeleteSupplierCommand = new RelayCommand(delete_E, delete_C);
            SaveSuppliersCommand = new RelayCommand(saveCs_E, saveCs_C);
            RefreshAllSuppliers = new RelayCommand(refreshCs_E, refreshCs_C);
            SaveNewSupplierCommand = new RelayCommand(saveNc_E, saveNc_C);
            ClearBoxes = new RelayCommand(cBoxes_E, cBoxes_C);
            SearchSupplierCommand = new RelayCommand(_ =>
            {
                SearchSupplier();
            });
        }

        #endregion


        #region commandMethods


        private void cBoxes_E(object obj)
        {
            NewSupplier = new Supplier();
            Error = "";
        }

        private bool cBoxes_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Can Execute Method for saving a new Supplier
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private bool saveNc_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Execute Method for saving a new Supplier
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private void saveNc_E(object obj)
        {
            
            //Check if the Supplier has already been added
            var Supplier = db.Suppliers.Where(i => i.Email == newSupplier.Email && i.Phone == newSupplier.Phone && i.Name == newSupplier.Name).FirstOrDefault();
            bool IsSupplierValid = ValidateNewSupplier(NewSupplier);
            if (Supplier == null && IsSupplierValid)
            {
                //Associate the Supplier to the current Company
                NewSupplier.CompanyId = SelectedCompany.CompanyId;
                // add the new Supplier
                db.Suppliers.Add(NewSupplier);

                db.SaveChanges();
                refreshCs_E(null);
                // show messagebox to alert success;
                MessageBox.Show("Supplier Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (Supplier != null)
            {
                Error = this["Duplicate"];
                return;
            }
            if (!IsSupplierValid)
                return;

            // show Message Box  to alert failure
            MessageBox.Show("Failed to add supplier", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private new void refreshCs_E(object obj)
        {
            cBoxes_E(null);
            AllSuppliers = new ObservableCollection<Supplier>(SelectedCompany.Suppliers);
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
            if (allSuppliersSelectedId == null || allSuppliersSelectedId < 0)
                return false;
            else
                return true;
        }

        private async void delete_E(object obj)
        {
            try
            {

                if (allSuppliersSelectedId == null || allSuppliersSelectedId < 0)
                {
                    MessageBox.Show("Please select a supplier to delete");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete the selected Supplier", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    db.Suppliers.Remove(db.Suppliers.Find(allSuppliersSelectedId));
                    await db.SaveChangesAsync();
                    AllSuppliers.Remove(db.Suppliers.Find(allSuppliersSelectedId));
                    refreshCs_E(null);
                }
                  
            }
            catch
            {

            }
        }

        #endregion

        #region Methods

        public bool ValidateNewSupplier(Supplier Supplier)
        {
            if (Supplier.Name == null || Supplier.Address == null 
                 || Supplier.Phone == null || Supplier.Email == null)
            {
                Error = this["NewSupplier"];
                return false;
            }

            Error = null;
            return true;

        }

        public async void SearchSupplier()
        {
            ObservableCollection<Supplier> searchedSuppliers = new ObservableCollection<Supplier>(db.Suppliers.Where(i=>i.CompanyId == SelectedCompany.CompanyId));

            await Task.Run(() =>
            {
                if (SearchBy == "Name")
                    searchedSuppliers = new ObservableCollection<Supplier>(searchedSuppliers.Where(i => i.Name.ToLower() == SearchString.ToLower()));
                else if (SearchBy == "Email")
                    searchedSuppliers = new ObservableCollection<Supplier>(searchedSuppliers.Where(i => i.Email.ToLower() == SearchString.ToLower()));
            });

            AllSuppliers = searchedSuppliers;
        }

        #endregion
    }
}
