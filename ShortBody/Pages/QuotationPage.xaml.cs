using ShortBody.Models;
using ShortBody.Reports;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for QuotationPage.xaml
    /// </summary>
    public partial class QuotationPage : Page
    {
        public QuotationViewModel viewModel;
        public static QuotationPage quotationPage;
        
        public QuotationPage()
        {
            InitializeComponent();
            viewModel = new QuotationViewModel();
            DataContext = viewModel;
            quotationPage = this;
        }

        private void MainGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                DataGrid MainGrid = (DataGrid)sender;
                viewModel.allClientsSelectedId = (MainGrid.SelectedItem as Client).ClientId;
                viewModel.SetSelectedClient();
               
                viewModel.selectedQuotationId = null;
            }
            catch { }
       
        }

        private void AddQuotation_Loaded(object sender, RoutedEventArgs e)
        {

            AddQuotationWindow.Visibility = Visibility.Collapsed;
        }

        private void AddQuotation_Click(object sender, RoutedEventArgs e)
        {
            if (AddQuotationWindow.Visibility != Visibility.Visible)
                AddQuotationWindow.Resize();
        }

        private void Quotation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                viewModel.selectedQuotationId = ((dynamic)(((DataGrid)sender).SelectedItem as Quotation)).QuotationId;
                viewModel.ChangeSelectedQuotation();
                e.Handled = true;
            }
            catch { }
        }

        private void ViewQuotation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var qt = new QuotationReport(viewModel);
                qt.Owner = MainWindow.mainWindow;
                qt.ShowDialog();
            }
            catch { }
            

        }

        private void btnClientQuotation_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ReportedQuotation = viewModel.ClientQuotation;
            new QuotationsReport("Client",viewModel, viewModel.selectedClient.Name).ShowDialog();
        }

        private void AllQuotations_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ReportedQuotation = viewModel.allQuotations;
            new QuotationsReport("All",viewModel, " All Clients").ShowDialog();
        }

        private void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Methods.PreviewMouseWheelEventHandler(sender, e);
        }

     

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {        
            if (DashBoard.db1 != null)
                viewModel.SaveSearch(ref DashBoard.db1);
            else
                viewModel.db.SaveChanges();

            DashBoard.dashBoard.OnUnpaidQuotationChanged();
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
