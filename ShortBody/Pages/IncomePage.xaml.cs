using ShortBody.Models;
using ShortBody.Reports;
using ShortBody.Resources.Helper_Methods;
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
    /// Interaction logic for IncomePage.xaml
    /// </summary>
    public partial class IncomePage : UserControl
    {
        EIviewModel viewModel;
        public static IncomePage incomePage;

        public IncomePage()
        {
            InitializeComponent();
            viewModel = new EIviewModel();
            DataContext = viewModel;

            incomePage = this;
        }

        private void MainIncomeGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try { viewModel.allIncomesSelectedId = ((Income)grid.SelectedItem)?.IncomeId; } catch { }

        }
        private void btnAddIncome_Click(object sender, RoutedEventArgs e)
        {
            if (AddIncomeWindow.Visibility != Visibility.Visible)
            {
                AddIncomeWindow.Resize();
               
            }
               
        }

        private void AddIncomeWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddIncomeWindow.Visibility = Visibility.Collapsed;
            
        }

       

        private void IncomeStatment_Click(object sender, RoutedEventArgs e)
        {
            new IncomeReport(viewModel).ShowDialog();
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
