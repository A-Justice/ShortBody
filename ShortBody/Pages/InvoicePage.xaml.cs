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
    /// Interaction logic for InvoicePage.xaml
    /// </summary>
    public partial class InvoicePage : Page
    {
        public InvoiceViewModel viewModel;

        public static InvoicePage invoicePage;
        public InvoicePage()
        {
            InitializeComponent();
            viewModel = new InvoiceViewModel();
            DataContext = viewModel;
            invoicePage = this;
        }

        private void AddInvoice_Click(object sender, RoutedEventArgs e)
        {
            
            if (AddInvoiceWindow.Visibility!=Visibility.Visible)
            AddInvoiceWindow.Resize();
        }

        private void AddInvoiceWindow_Loaded(object sender, RoutedEventArgs e)
        {
           
            AddInvoiceWindow.Visibility = Visibility.Collapsed;
        }

        private void InvoiceDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {          
                GetId<Client,Supplier>(sender, ref viewModel.CurrentSelectedId);
               viewModel.SetCurrentSupplierOrClient();
            // Deselec the currently selected invoice to disable some controls
                 //viewModel.selectedInvoiceId = -1;

        }

        private void ClientInvoices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetId<ClientInvoice,SupplierInvoice>(sender, ref viewModel.selectedInvoiceId);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int GetId<T,M>(object grid, ref int? idVariable)
            where T : class, new()
            where M : class,new()
        {
            int i = -1;
            try
            {
                if (viewModel.InvoiceFor == "Clients")
                {
                    if(new T() is ClientInvoice)
                    i = ((dynamic)(((DataGrid)grid).SelectedItem as T)).ClientInvoiceId;
                    else
                        i = ((dynamic)(((DataGrid)grid).SelectedItem as T)).ClientId;
                    idVariable = i;
                }
                else if (viewModel.InvoiceFor == "Suppliers")
                {
                    if(new M() is SupplierInvoice)
                    i = ((dynamic)(((DataGrid)grid).SelectedItem as M)).SupplierInvoiceId;
                    else
                      i=  ((dynamic)(((DataGrid)grid).SelectedItem as M)).SupplierId;
                    idVariable = i;
                }
            }
            catch 
            {
                idVariable = -1;
            }

            return i;
        }

        private   void AllInvoices_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ResetInvoiceFor();

            showReport(SetWho(false));
        }

        private  void viewInvoice_Click(object sender, RoutedEventArgs e)
        {
             viewModel.ViewInvoice_E(null);
            showReport(SetWho(true));
        }
        

        private  void showReport(string who)
        {
            new InvoiceReport(viewModel,who).ShowDialog();
        }

        /// <summary>
        /// Determine the who parameter for the quotations report page
        /// </summary>
        /// <param name="IsSingleInvoice">Whether We want all invoices or invoice for a single client or supplier</param>
        /// <returns></returns>
        string SetWho(bool IsSingleInvoice)
        {
            string who = "";

            if (viewModel.InvoiceFor == "Clients")
            {
                if (IsSingleInvoice)
                    who = viewModel.NameForCurrent;
                else
                    who = " All Clients";
               
            }
            else if (viewModel.InvoiceFor == "Suppliers")
            {
                if (IsSingleInvoice)
                    who = viewModel.NameForCurrent;
                else
                    who = " All Suppliers";
            }

            return who;

        }

        private void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Methods.PreviewMouseWheelEventHandler(sender, e);
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            viewModel.db.SaveChanges();
            if (viewModel.db1 !=null)
            viewModel.SaveSearch(ref viewModel.db1);
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
