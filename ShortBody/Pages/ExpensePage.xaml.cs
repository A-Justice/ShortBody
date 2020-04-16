using ShortBody.Models;
using ShortBody.Reports;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for ExpensePage.xaml
    /// </summary>
    public partial class ExpensePage : UserControl
    {
        EIviewModel viewModel;
        public static ExpensePage expensePage;

        public ExpensePage()
        {
            InitializeComponent();
            viewModel = new EIviewModel();
            DataContext = viewModel;
            expensePage = this;
        }

        private void MainExpenseGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try { viewModel.allExpenceSelectedId = ((Expense)grid.SelectedItem)?.Id; } catch { }

        }
        private void btnAddExpense_Click(object sender, RoutedEventArgs e)
        {
            if (AddExpenseWindow.Visibility != Visibility.Visible)
                AddExpenseWindow.Resize();
        }

        private void AddExpenseWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddExpenseWindow.Visibility = Visibility.Collapsed;
        }

        private void ExpenseStatment_Click(object sender, RoutedEventArgs e)
        {
            new ExpenseReport(viewModel).ShowDialog();
        }

        private void cboSearchBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSearchBox.SelectedIndex == 0)
            {
                txtSearchBox.Visibility = Visibility.Collapsed;
                return;
            }
            txtSearchBox.Visibility = Visibility.Visible;
        }
    }
}
