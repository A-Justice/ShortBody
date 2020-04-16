using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for PaymentAdvice.xaml
    /// </summary>
    public partial class PaymentAdvice : Window
    {
        EIviewModel vm;
        DataGrid grid;
        public PaymentAdvice(EIviewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            viewModel.ResetPaymentAdvice();
            vm = viewModel;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                helperPanel.Visibility = Visibility.Collapsed;
                TopPanel.Visibility = Visibility.Collapsed;
                document.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
                //Methods.alloPrint(document);
                Methods.PrintOnMultiPage(document);
            }
            catch { }
            finally
            {
                TopPanel.Visibility = Visibility.Visible;
                helperPanel.Visibility = Visibility.Visible;
                document.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            vm.db.SaveChanges();
        }

        private void AdvicesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                grid = (sender as DataGrid);
                Advice item = grid.SelectedItem as Advice;

                vm.SelectedItemId = item.AdviceId;
            }
            catch { }
        }

        private async void AdvicesDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                var grid = (sender as DataGrid);
                Advice item = e.Row.Item as Advice;

                if (e.Column.Header.ToString() == "Amount(GHS)")
                {
                    TextBox tb = e.EditingElement as TextBox;
                    item.Amount = tb.Text;

                    try
                    {
                        Convert.ToDecimal(tb.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please Enter numeric values in the Amount Field", "Invalid Value", MessageBoxButton.OK, MessageBoxImage.Error);
                        item.Amount = "0";
                        tb.Text = "";
                    }
                }

                await GetTotalValues();

                vm.db.SaveChanges();
            }
            catch { }
        }

        Task GetTotalValues()
        {

            return Task.Run(() =>
            {

                try
                {
                    decimal subTotal = 0;
                    double vat = vm.PaymentAdvice.VatRate;
                    decimal VatAmount = 0;
                    decimal Total = 0;
                    vm.PaymentAdvice.Advices.ToList().ForEach(i => subTotal += Convert.ToDecimal(i.Amount));
                    VatAmount = (decimal)(vat / 100) * subTotal;
                    Total = subTotal + VatAmount;
                    Dispatcher.BeginInvoke(new Action(() => {
                        tbSubTotal.Text = subTotal.ToString();
                        tbVat.Text = vat.ToString();
                        tbVatAmount.Text = VatAmount.ToString();
                        tbTotal.Text = Total.ToString();
                    }), null);
                }
                catch { }

            });
        }

        private async void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            AdvicesDataGrid_SelectionChanged(grid, null);
            vm.signal = new ManualResetEvent(false);
            vm.db.SaveChanges();
            await Task.Run(() =>
            {
                vm.signal.WaitOne();
                GetTotalValues();
            });
            AdvicesDataGrid.DataContext = null;
            AdvicesDataGrid.DataContext = vm.PaymentAdvice;
        }
    }
}
