using Microsoft.Win32;
using ShortBody.Models;
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
    /// Interaction logic for CompanyPage.xaml
    /// </summary>
    public partial class CompanyPage : UserControl
    {
       
        CompanyPageViewModel viewModel;
        public static CompanyPage companyPage;
        public CompanyPage()
        {

            InitializeComponent();
            viewModel = new CompanyPageViewModel();
            DataContext = viewModel;

            companyPage = this;

        }

        private void AddOperation_Click(object sender, RoutedEventArgs e)
        {
            if (AddOperationWindow.Visibility != Visibility.Visible)
            {
                AddAccDetailWindow.Visibility = Visibility.Collapsed;
                AddCompanyWindow.Visibility = Visibility.Collapsed;
                AddOperationWindow.Visibility = Visibility.Visible;

            }
        }

        private void MainCompanyGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try { viewModel.allCompanySelectedId = ((Company)grid.SelectedItem)?.CompanyId; } catch { }
            viewModel.SetFocusedCompany();
        }

        private void OperationsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try { viewModel.allOperationSelectedId = ((Operation)grid.SelectedItem)?.OperationId; } catch { }
        }


        private void btnAddCompany_Click(object sender, RoutedEventArgs e)
        {
            if (AddCompanyWindow.Visibility != Visibility.Visible)
            {
                AddOperationWindow.Visibility = Visibility.Collapsed;
                AddAccDetailWindow.Visibility = Visibility.Collapsed;
                AddCompanyWindow.Visibility = Visibility.Visible;


            }

        }

        private void companyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddCompanyWindow.Visibility = Visibility.Collapsed;
            AddOperationWindow.Visibility = Visibility.Collapsed;
            AddAccDetailWindow.Visibility = Visibility.Collapsed;
            ViewAccWindow.Visibility = Visibility.Collapsed;
        }


        private void AccountGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try { viewModel.allAccDetailSelectedId = ((CompanyAccountDetail)grid.SelectedItem)?.CompanyAccountDetailId; } catch { }
        }

        private void ViewAccDetail_Click(object sender, RoutedEventArgs e)
        {
            if (ViewAccWindow.Visibility != Visibility.Visible)
            {
                ViewAccWindow.Resize();
            }
        }

        private void ChangeImage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ResetCompanyLogo();
        }

        private void DataGrid_TargetUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Methods.PreviewMouseWheelEventHandler(sender, e);
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

        private void AddAccDetail_Click(object sender, RoutedEventArgs e)
        {
            if(AddAccDetailWindow.Visibility != Visibility.Visible)
            {
                AddOperationWindow.Visibility = Visibility.Collapsed;
                AddCompanyWindow.Visibility = Visibility.Collapsed;
                AddAccDetailWindow.Visibility = Visibility.Visible;
            
                
            }
        }
    }
}
