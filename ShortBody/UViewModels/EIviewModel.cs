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
using fm = System.Windows.Forms;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class EIviewModel : DashBoardViewModel, IDataErrorInfo
    {


        #region publicVariables
        public ManualResetEvent signal = new ManualResetEvent(false);
        public int? allExpenceSelectedId;
        public int? allIncomesSelectedId;
        public int? SelectedPaymentAdviceId;
        public int? SelectedItemId;

        #endregion

        #region PrivateVariables
        private string searchBy;
        private string searchString;
        SynchronizationContext currentContext;
        private ObservableCollection<Expense> allExpenses;
        private Expense newExpense;
        private ObservableCollection<Income> allIncomes;
        private Income newIncome;
        private string error;
        
        private ObservableCollection<PaymentAdvice> paymentAdvices;
        private PaymentAdvice paymentAdvice;
        private PaymentAdvice newPaymentAdvice;

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
        public ObservableCollection<PaymentAdvice> PaymentAdvices
        {
            get { return paymentAdvices; }
            set { paymentAdvices = value; OnPropertyChanged(); }
        }
        public PaymentAdvice PaymentAdvice
        {
            get { return paymentAdvice; }
            set { paymentAdvice = value; OnPropertyChanged(); }
        }

        public PaymentAdvice NewPaymentAdvice
        {
            get { return newPaymentAdvice; }
            set { newPaymentAdvice = value; OnPropertyChanged(); }
        }


        public RelayCommand DeleteIncomeCommand { get; set; }
        public RelayCommand DeleteExpenseCommand { get; set; }
        public RelayCommand SaveExpenseCommand { get; set; }

        public RelayCommand SaveIncomeCommand { get; set; }

        public ObservableCollection<Expense> AllExpensesShadow { get; set; }
        public ObservableCollection<Expense> AllExpenses
        {
            get
            {
                return allExpenses;
            }
            set
            {
                allExpenses = value;
                OnPropertyChanged();
            }
        }


        public Expense NewExpense
        {
            get
            {
                return newExpense;
            }
            set
            {
                newExpense = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Income> AllIncomesShadow { get; set; }


        public ObservableCollection<Income> AllIncomes
        {
            get
            {
                return allIncomes;
            }
            set
            {
                allIncomes = value;
                OnPropertyChanged();
            }
        }


        public Income NewIncome
        {
            get
            {
                return newIncome;
            }
            set
            {
                newIncome = value;
                OnPropertyChanged();
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

        public RelayCommand ClearBoxes { get; private set; }
        public RelayCommand SavePaymentAdviceCommand { get; private set; }
        public RelayCommand AddPaCommand { get; private set; }
        public RelayCommand ViewPaCommand { get; private set; }
        public RelayCommand DeleteItemCommand { get; private set; }
        public RelayCommand DeletePaCommand { get; private set; }
        public RelayCommand SearchIncomeCommand { get; private set; }
        public RelayCommand SearchExpenseCommand { get; private set; }
        public RelayCommand SearchPaymentAdviceCommand { get; private set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewExpense" || columnName == "NewIncome")
                {
                    return "Please provide values for all fields";
                }

                return null;
            }
        }
        #endregion

        #region Constructor

        public EIviewModel()
        {
            currentContext = SynchronizationContext.Current;
            paymentAdvice = new PaymentAdvice();
            newPaymentAdvice = new PaymentAdvice();
            AllExpenses = new ObservableCollection<Expense>(SelectedCompany.Expenses);
            AllExpensesShadow = new ObservableCollection<Expense>(SelectedCompany.Expenses);
            newExpense = new Expense();
            PaymentAdvices = new ObservableCollection<PaymentAdvice>(SelectedCompany.PaymentAdvices);
            AllIncomes = new ObservableCollection<Income>(SelectedCompany.Incomes);
            AllIncomesShadow = new ObservableCollection<Income>(SelectedCompany.Incomes);
            SavePaymentAdviceCommand = new RelayCommand(saveNpa_E);
            newIncome = new Income();
            SaveExpenseCommand = new RelayCommand(saveNe_E, saveNe_C);
            SaveIncomeCommand = new RelayCommand(saveNi_E, saveNi_C);
            DeleteIncomeCommand = new RelayCommand(deleteI_E, deleteI_C);
            DeleteExpenseCommand = new RelayCommand(deleteE_E, deleteE_C);
            DeleteItemCommand = new RelayCommand(DeleteItem_E, DeleteItem_C);
            DeletePaCommand = new RelayCommand(DeletePa_E, t =>
            {
                if (SelectedPaymentAdviceId != null)
                    return true;
                return false;
            });
            AddPaCommand = new RelayCommand(null, t =>
            {
                return true;
            });
            ViewPaCommand = new RelayCommand(null, t =>
            {
                if (SelectedPaymentAdviceId != null)
                    return true;
                return false;
            });
            ClearBoxes = new RelayCommand(p =>
            {
                if (p?.ToString() == "E")
                {
                    NewExpense = new Expense();
                }
                else if (p?.ToString() == "CPA")
                {
                    NewPaymentAdvice = new PaymentAdvice();
                }
                else
                {
                    NewIncome = new Income();
                }
            });
            SearchIncomeCommand = new RelayCommand(_ =>
            {
                SearchIncome();
            });
            SearchExpenseCommand = new RelayCommand(_ =>
            {
                SearchExpense();
            });
            SearchPaymentAdviceCommand = new RelayCommand(_ =>
            {
                SearchPaymentAdvice();
            });
        }

        private void DeletePa_E(object obj)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected Payment Advice ? ", "Confirm delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {

                    if (SelectedPaymentAdviceId == null || SelectedPaymentAdviceId < 0)
                        return;

                    PaymentAdvice iv = db.PaymentAdvices.Find(SelectedPaymentAdviceId);


                    db.PaymentAdvices.Remove(iv);



                    db.SaveChanges();
                    PaymentAdvices = new ObservableCollection<PaymentAdvice>(db.PaymentAdvices);
                    SelectedPaymentAdviceId = -1;
                }
                catch 
                {
                    MessageBox.Show("Unable to Delete PaymentAdvice", "Deletion Failed", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
        }

        private void saveNpa_E(object obj)
        {
            if (NewPaymentAdvice != null)
            {
                NewPaymentAdvice.Date = DateTime.Now;
                NewPaymentAdvice.IssuedBy = CurrentUser.FirstName;
                NewPaymentAdvice.CompanyId = SelectedCompany.CompanyId;

                db.PaymentAdvices.Add(NewPaymentAdvice);

                db.SaveChanges();
                ClearBoxes.Execute("CPA");
                PaymentAdvices = new ObservableCollection<PaymentAdvice>(db.PaymentAdvices);

                // show messagebox to alert success;
                MessageBox.Show("Payment Advice Added successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            MessageBox.Show("Failed to Add Payment Advice", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Information);

        }


        #endregion


        #region Methods
        public bool ValidateNewExpense(Expense Ex)
        {
            if (Ex.PaymentVoucherNumber == null || Ex.Description == null)
            {
                Error = this["NewExpense"];
                return false;
            }
            NewExpense.CompanyId = SelectedCompany.CompanyId;
            Error = null;
            return true;

        }


        public bool ValidateNewIncome(Income In)
        {
            if (In.ChequeNumber == null || In.Payee == null)
            {
                Error = this["NewIncome"];
                return false;
            }
            NewIncome.Date = DateTime.Now;
            NewIncome.CompanyId = SelectedCompany.CompanyId;
            Error = null;
            return true;

        }


        void RefreshExpenses()
        {

            AllExpenses = new ObservableCollection<Expense>(SelectedCompany.Expenses);
            AllExpensesShadow = new ObservableCollection<Expense>(SelectedCompany.Expenses);
        }

        void RefreshIncome()
        {
            AllIncomes = new ObservableCollection<Income>(SelectedCompany.Incomes);
            AllIncomesShadow = new ObservableCollection<Income>(SelectedCompany.Incomes);
        }

        #endregion

        #region CommandMethods
        private bool DeleteItem_C(object obj)
        {
            if (SelectedItemId != null)
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
                    Advice item = db.Advices.Find((int)SelectedItemId);



                    currentContext.Post(t =>
                    {
                        if (item != null)
                        {
                            db.Advices.Remove(item);
                            paymentAdvice.Advices.Remove(item);
                            db.SaveChanges();

                        }
                        signal.Set();
                    }, null);

                    signal.WaitOne();
                    currentContext.Post(t =>
                    {
                        PaymentAdvice = paymentAdvice;
                    }, null);

                }
            }
            catch  { }

        }


        private bool deleteE_C(object obj)
        {
            if (allExpenceSelectedId == null || allExpenceSelectedId < 0)
                return false;
            else
                return true;
        }

        private async void deleteE_E(object obj)
        {
            try
            {

                if (allExpenceSelectedId == null || allExpenceSelectedId < 0)
                {
                    MessageBox.Show("Please Select an Expense to delete");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete the selected Expense", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    db.Expenses.Remove(db.Expenses.Find(allExpenceSelectedId));
                    await db.SaveChangesAsync();
                    AllExpenses.Remove(db.Expenses.Find(allExpenceSelectedId));
                    AllExpensesShadow.Remove(db.Expenses.Find(allExpenceSelectedId));
                    RefreshExpenses();
                }

            }
            catch 
            {

            }
        }


        private bool deleteI_C(object obj)
        {
            if (allIncomesSelectedId == null || allIncomesSelectedId < 0)
                return false;
            else
                return true;
        }

        private async void deleteI_E(object obj)
        {
            try
            {

                if (allIncomesSelectedId == null || allIncomesSelectedId < 0)
                {
                    MessageBox.Show("Please Select an income to delete");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete the selected Income", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    db.Incomes.Remove(db.Incomes.Find(allIncomesSelectedId));
                    await db.SaveChangesAsync();
                    AllIncomes.Remove(db.Incomes.Find(allIncomesSelectedId));
                    AllIncomesShadow.Remove(db.Incomes.Find(allIncomesSelectedId));
                    RefreshIncome();
                }
            }
            catch 
            {

            }
        }



        /// <summary>
        /// Can Execute Method for saving a new Expense
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private bool saveNe_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Execute Method for saving a new expense
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private void saveNe_E(object obj)
        {

            //Check if the Expense has already been added
            var Expense = db.Expenses.Where(i => i.Amount == NewExpense.Amount && i.PaymentVoucherNumber == NewExpense.PaymentVoucherNumber
            && i.Description == NewExpense.Description).FirstOrDefault();

            if (Expense != null)
            {
                if (MessageBox.Show("An Expense with the same details exist do you want to add it anyway", "Duplicate", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.No)
                {
                    return;
                }
            }
            bool IsExpenseValid = ValidateNewExpense(NewExpense);

            if (IsExpenseValid)
            {
                //Associate the Expense to the current Company
                NewExpense.CompanyId = SelectedCompany.CompanyId;
                NewExpense.Date = DateTime.Now;
                // add the new Expense
                db.Expenses.Add(NewExpense);

                db.SaveChanges();

                RefreshExpenses();
                ClearBoxes.Execute("E");
                // show messagebox to alert success;
                MessageBox.Show("Expense Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (!IsExpenseValid)
                return;

            // show Message Box  to alert failure
        }


        /// <summary>
        /// Can Execute Method for saving a new Expense
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private bool saveNi_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Execute Method for saving a new expense
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private void saveNi_E(object obj)
        {

            //Check if the Income has already been added
            var Income = db.Incomes.Where(i => i.Amount == NewIncome.Amount && i.Payee == NewIncome.Payee
            && i.ChequeNumber == NewIncome.ChequeNumber).FirstOrDefault();

            if (Income != null)
            {
                if (MessageBox.Show("An Income with the same details exist do you want to add it anyway", "Duplicate", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.No)
                {
                    return;
                }
            }

            if (ValidateNewIncome(NewIncome))
            {
                //Associate the Income to the current Company
                NewIncome.CompanyId = SelectedCompany.CompanyId;
                // NewIncome.PaymentAdvices = null;
                // add the new Income
                db.Incomes.Add(NewIncome);

                db.SaveChanges();
                RefreshIncome();
                NewIncome = new Income();
                // show messagebox to alert success;
                MessageBox.Show("Income Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            MessageBox.Show("Failed to add Income", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        #endregion


        #region Miscellenous

        public void GeneratePaymentAdvice()
        {
            if (allIncomes.Count > 0)
            {
                paymentAdvice = new PaymentAdvice()
                {
                    Date = DateTime.Now,
                    ChequeNumber = AllIncomes.Where(i => i.IncomeId == allIncomesSelectedId).FirstOrDefault()?.ChequeNumber,
                    CompanyName = AllIncomes.Where(i => i.IncomeId == allIncomesSelectedId).FirstOrDefault()?.AssociatedCompany.Name,
                };
            }

            //PaymentAdvice.Add(pa);          
        }

        public void ResetPaymentAdvice()
        {
            PaymentAdvice = db.PaymentAdvices.Find(SelectedPaymentAdviceId);
        }

        public async void SearchIncome()
        {
            ObservableCollection<Income> searchedIncomes = new ObservableCollection<Income>(db.Incomes.Where(i => i.CompanyId == SelectedCompany.CompanyId));

            await Task.Run(() =>
            {
                if (SearchBy == "Cheque #")
                    searchedIncomes = new ObservableCollection<Income>(searchedIncomes.Where(i => i.ChequeNumber.ToLower() == SearchString.ToLower()));
                else if (SearchBy == "Payee")
                    searchedIncomes = new ObservableCollection<Income>(searchedIncomes.Where(i => i.Payee.ToLower() == SearchString.ToLower()));
            });

            AllIncomes = searchedIncomes;
        }

        public async void SearchExpense()
        {
            ObservableCollection<Expense> searchedExpenses = new ObservableCollection<Expense>(db.Expenses.Where(i => i.AssociatedCompany.CompanyId == SelectedCompany.CompanyId));

            await Task.Run(() =>
            {
                if (SearchBy == "P-Voucher #")
                    searchedExpenses = new ObservableCollection<Expense>(searchedExpenses.Where(i => i.PaymentVoucherNumber.ToLower() == SearchString.ToLower()));

            });

            AllExpenses = searchedExpenses;
        }

        public async void SearchPaymentAdvice()
        {
            ObservableCollection<PaymentAdvice> searchedPaymentAdvices = new ObservableCollection<PaymentAdvice>(db.PaymentAdvices.Where(i => i.CompanyId == SelectedCompany.CompanyId));

            await Task.Run(() =>
            {
                if (SearchBy == "Company Name")
                    searchedPaymentAdvices = new ObservableCollection<PaymentAdvice>(searchedPaymentAdvices.Where(i => i.CompanyName == SearchString));
                else if (SearchBy == "Cheque #")
                    searchedPaymentAdvices = new ObservableCollection<PaymentAdvice>(searchedPaymentAdvices.Where(i => i.ChequeNumber == SearchString));

            });

            PaymentAdvices = searchedPaymentAdvices;
        }

        #endregion

    }
}
