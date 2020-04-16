using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace ShortBody.Reports
{
    /// <summary>
    /// Interaction logic for QuotationReport.xaml
    /// </summary>
    public partial class QuotationReport : Window
    {

        FlowDocumentScrollViewer document;
        QuotationViewModel vm;
        DataGridCell currentCell;
        DataGrid grid;
        TextBox tb = null;
        int NumberOfAccounts;


        public QuotationReport(QuotationViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
            vm = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                document.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
                helperPanel.Visibility = Visibility.Collapsed;
                TopPanel.Visibility = Visibility.Collapsed;
                SpAccountNavigator.Visibility = Visibility.Collapsed;
                //Methods.alloPrint(document);
               

                Methods.Print(document);
            }
            catch { }
            finally
            {
                TopPanel.Visibility = Visibility.Visible;
                helperPanel.Visibility = Visibility.Visible;
                SpAccountNavigator.Visibility = Visibility.Visible;
                document.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            }


        }

        private void FlowDocumentPageViewer_Loaded(object sender, RoutedEventArgs e)
        {

            document = sender as FlowDocumentScrollViewer;
            NumberOfAccounts = vm.SelectedCompany.AccountDetails.Count;
            if (NumberOfAccounts <= 1)
            {
                btnUp.IsEnabled = false;
                btnDown.IsEnabled = false;
            }
            //else if( NumberOfAccounts >1 )
            //{
            //    btnUp.IsEnabled = true;
            //    btnDown.IsEnabled = true;
            //}
            if (NumberOfAccounts == 1)
                vm.CompanyAccDetails = vm.SelectedCompany.AccountDetails.FirstOrDefault();

            vm.accountCounter = 1;


        }

        private void ItemsDataGrid_KeyUp(object sender, KeyEventArgs e)
        {



        }

        private void ItemsDataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            try
            {
                currentCell = GetDataGridCell((sender as DataGrid).CurrentCell);

            }
            catch { }
            finally
            {

            }

        }

        private async void ItemsDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var grid = (sender as DataGrid);

            QuotationItem item = e.Row.Item as QuotationItem;
            tb = e.EditingElement as TextBox;
            try
            {
                if (e.Column.Header.ToString() == "QTY")
                {
                    double tbValue = Convert.ToDouble(tb.Text);
                    if (!string.IsNullOrEmpty(item.UnitCost))
                        item.TotalCost = tbValue * Convert.ToDouble(item.UnitCost);
                }
                else if (e.Column.Header.ToString() == "UnitCost")
                {
                    double tbValue = Convert.ToDouble(tb.Text);
                    if (!string.IsNullOrEmpty(item.QTY))
                        item.TotalCost = tbValue * Convert.ToDouble(item.QTY);
                }

            }
            catch
            {
                item.TotalCost = 0;
                MessageBox.Show("Please Use appopriate Values int the grid boxes", "Invalid Value", MessageBoxButton.OK, MessageBoxImage.Warning);
                tb.Text = "";
            }

            await GetTotalValues();

            vm.db.SaveChanges();
        }

        Task GetTotalValues()
        {

            return Task.Run(() =>
            {


                decimal subTotal = 0;
                var vat = vm.SelectedQuotation.Vat_Nhil;
                decimal VatAmount = 0;
                decimal Total = 0;
                vm.SelectedQuotation.Items.ToList().ForEach(i => subTotal += (decimal)i.TotalCost);
                VatAmount = (vat / 100) * subTotal;
                Total = subTotal + VatAmount;
                Dispatcher.BeginInvoke(new Action(() => {
                    tbSubTotal.Text = subTotal.ToString();
                    tbVat.Text = vat.ToString();
                    tbVatAmount.Text = VatAmount.ToString();

                    tbTotal.Text = Total.ToString();
                }), null);
            });
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            vm.db.SaveChanges();
        }

        private void ItemsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                grid = (sender as DataGrid);
                QuotationItem item = grid.SelectedItem as QuotationItem;

                vm.SelectedItemId = item.Id;
            }
            catch { }

        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ItemsDataGrid_SelectionChanged(grid, null);
            vm.signal = new ManualResetEvent(false);
            vm.db.SaveChanges();
            await Task.Run(() =>
            {
                vm.signal.WaitOne();
                GetTotalValues();
            });

        }

        private void CounterBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;


            if (btn.Name == "btnUp")
            {

                tbCounter.Text = (vm.AccountCounter = vm.accountCounter + 1).ToString();
                btnDown.IsEnabled = true;
                if (vm.accountCounter >= NumberOfAccounts)
                {
                    btnUp.IsEnabled = false;
                }


            }
            else
            {
                tbCounter.Text = (vm.AccountCounter = vm.accountCounter - 1).ToString();
                btnUp.IsEnabled = true;
                if (vm.accountCounter == 1)
                    btnDown.IsEnabled = false;
            }
        }

        private void btnBolden_Click(object sender, RoutedEventArgs e)
        {

            currentCell.SetValue(FontWeightProperty, FontWeights.Bold);
        }

        private void btnUnderline_Click(object sender, RoutedEventArgs e)
        {

            TextBlock box = (currentCell.Content as TextBlock);
            box.TextDecorations = TextDecorations.Underline;

        }

        private void btnItalicize_Click(object sender, RoutedEventArgs e)
        {
            currentCell.SetValue(FontStyleProperty, FontStyles.Italic);
        }

        private void btnClearFormatting_Click(object sender, RoutedEventArgs e)
        {
            currentCell.SetValue(FontWeightProperty, FontWeights.Normal);
            TextBlock box = (currentCell.Content as TextBlock);
            box.TextDecorations = null;
            currentCell.SetValue(FontStyleProperty, FontStyles.Normal);
        }

        public DataGridCell GetDataGridCell(DataGridCellInfo cellInfo)
        {
            var cellContent = cellInfo.Column.GetCellContent(cellInfo.Item);

            if (cellContent != null)
                return (DataGridCell)cellContent.Parent;

            return null;


        }

        private void ItemsDataGrid_Sorting(object sender, DataGridSortingEventArgs e)
        {
            e.Handled = true;
        }

        private void btnFsIncrease_Click(object sender, RoutedEventArgs e)
        {
            currentCell.FontSize += 1;
        }

        private void btnFsDecrease_Click(object sender, RoutedEventArgs e)
        {
            currentCell.FontSize -= 1;
        }

        private void ItemsDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            IEditableCollectionView itemsView = ItemsDataGrid.Items;

            if (ItemsDataGrid.Items.Count == 31 && itemsView.IsAddingNew == true)
            {
                itemsView.CommitNew();
                ItemsDataGrid.CanUserAddRows = false;
            }
        }

        public DataGridCell GetCell(int row, int column)
        {
            DataGridRow rowContainer = GetRow(row);
             
            if (rowContainer != null)
            {
                DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(rowContainer);

                DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(column);

                return cell;
            }
            return null;
        }


        public DataGridRow GetRow(int index)
        {
            DataGridRow row = (DataGridRow)grid.ItemContainerGenerator.ContainerFromIndex(index);

            return row ?? null;
        }

        public static T GetVisualChild<T>(Visual Parent)
            where T : Visual
        {
            T child = default(T);

            int numVisuals = VisualTreeHelper.GetChildrenCount(Parent);

            for (int i = 0; i < numVisuals; i++)
            {
                Visual v = (Visual)VisualTreeHelper.GetChild(Parent, i);
                child = v as T;
                if(child == null)
                {
                    child = GetVisualChild<T>(v);
                }
                if(child != null)
                {
                    break;
                }
            }
            return child;
        }

        private void PrintPreview_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                document.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
                helperPanel.Visibility = Visibility.Collapsed;
                TopPanel.Visibility = Visibility.Collapsed;
                SpAccountNavigator.Visibility = Visibility.Collapsed;
                //Methods.alloPrint(document);
               // MainGrid.Children.Remove(document);
                Methods.PrintPreview(this, document,true);
                //MainGrid.Children.Add(document);
            }
            catch(Exception ex) { }
            finally
            {
                TopPanel.Visibility = Visibility.Visible;
                helperPanel.Visibility = Visibility.Visible;
                SpAccountNavigator.Visibility = Visibility.Visible;
                document.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            }
        }

        private void ItemsDataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Methods.PreviewMouseWheelEventHandler(sender, e);
        }
    }
}
