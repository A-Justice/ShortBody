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
    /// Interaction logic for PaymentAdvicePage.xaml
    /// </summary>
    public partial class PaymentAdvicePage : Page
    {
        public static PaymentAdvicePage paymentAdvicePage;

        EIviewModel viewModel;
        public PaymentAdvicePage()
        {
            InitializeComponent();
            viewModel = new EIviewModel();
            DataContext = viewModel;
            paymentAdvicePage = this;
        }

        private void AddPaymentAdvice_Loaded(object sender, RoutedEventArgs e)
        {
            AddPaymentAdvice.Visibility = Visibility.Collapsed;
        }

        private void btnAddPaymentAdvice_Click(object sender, RoutedEventArgs e)
        {
            if (AddPaymentAdvice.Visibility != Visibility.Visible)
            {
                AddPaymentAdvice.Resize();
                //AddIncomeWindow.Visibility = Visibility.Collapsed;
            }
        }

        private void btnViewPaymentAdvice_Click(object sender, RoutedEventArgs e)
        {
            new Reports.PaymentAdvice(viewModel).ShowDialog();
        }

        private void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Methods.PreviewMouseWheelEventHandler(sender, e);
        }

        private void PaymentAdviceGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try
            {
                viewModel.SelectedPaymentAdviceId = ((Models.PaymentAdvice)grid.SelectedItem)?.PaymentAdviceId;

            }
            catch { }
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
