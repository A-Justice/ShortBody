using System.Windows;
using System.Windows.Controls;
using ShortBody.UViewModels;
using ShortBody.Models;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for SupplierPage.xaml
    /// </summary>
    public partial class SupplierPage : UserControl
    {
        SupplierPageViewModel viewModel;
        public static SupplierPage supplierPage;
        public SupplierPage()
        {

            InitializeComponent();
            viewModel = new SupplierPageViewModel();
            DataContext = viewModel;

            supplierPage = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainSupplierGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try { viewModel.allSuppliersSelectedId = ((Supplier)grid.SelectedItem)?.SupplierId; } catch { }

        }

        private void MainSupplierGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //var grid = sender as DataGrid;
            //viewModel.allSuppliersSelectedId = ((Supplier)grid.SelectedItem).SupplierId;
        }

        private void btnAddSupplier_Click(object sender, RoutedEventArgs e)
        {
            if (AddSupplierWindow.Visibility != Visibility.Visible)
                AddSupplierWindow.Resize();
        }

        private void AddSupplierWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddSupplierWindow.Visibility = Visibility.Collapsed;
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
