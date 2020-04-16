using ShortBody.Models;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShortBody.Reports
{
    /// <summary>
    /// Interaction logic for ExpenseReport.xaml
    /// </summary>
    public partial class ExpenseReport : Window
    {
        EIviewModel vm;
        public ExpenseReport(EIviewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            DcExpenses.DateChanged += DcExpenses_DateChanged;
            vm = viewModel;
        }

        private void DcExpenses_DateChanged(object sender, Resources.Helper_Methods.DateEventArgs e)
        {
            if (e.Date != null)
            {
                if (e.Month > 0 && e.Year > 0)
                    vm.AllExpenses = new ObservableCollection<Expense>(vm.AllExpensesShadow.Where(i => i.Date.Month == e.Month && i.Date.Year
                                                                               == e.Year));
                else if (e.Year > 0 && e.Month < 1)
                {
                    vm.AllExpenses = new ObservableCollection<Expense>(vm.AllExpensesShadow.Where(i => i.Date.Year
                                                                               == e.Year));
                }
                else if (e.Month > 0 && e.Year < 1)
                {
                    vm.AllExpenses = new ObservableCollection<Expense>(vm.AllExpensesShadow.Where(i => i.Date.Month == e.Month));
                }
            }
            else
            {
                vm.AllExpenses = new ObservableCollection<Expense>(vm.AllExpensesShadow);
            }
        }
    }
}
