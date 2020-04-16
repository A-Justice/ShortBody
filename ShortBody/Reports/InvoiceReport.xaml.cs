using ShortBody.Pages;
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
using System.Windows.Shapes;
using ShortBody.Resources.Helper_Methods;
using System.Collections.ObjectModel;
using ShortBody.Models;
using ShortBody.Resources.UserControls;
using System.Threading;

namespace ShortBody.Reports
{
    /// <summary>
    /// Interaction logic for InvoiceReport.xaml
    /// </summary>
    public partial class InvoiceReport : Window
    {
        InvoiceViewModel vm;
        decimal TotalVatValue = 0;
        decimal TotalAmount = 0;
        SynchronizationContext currentContext;

        public InvoiceReport(InvoiceViewModel viewModel,string who)
        {
            InitializeComponent();
            DcInvoice.Who = who;
            DataContext = viewModel;
            vm = viewModel;
            DcInvoice.DateChanged += DcInvoice_DateChanged;
            currentContext = SynchronizationContext.Current;
            //set The month to trigger the datechanged eventhandler when the window first loads
            
            DcInvoice.Month = 0;
        }

        private async void DcInvoice_DateChanged(object sender, DateEventArgs e)
        {
            if (vm.InvoiceFor == "Clients")
            {
                if (e.Month > 0 && e.Year > 0)
                    vm.Invoices = new ObservableCollection<ClientInvoice>(((ObservableCollection<ClientInvoice>)vm.InvoicesShadow).Where(i => i.Date.Month == e.Month && i.Date.Year
                                                                               == e.Year));
                else if (e.Year > 0 && e.Month < 1)
                {
                    vm.Invoices = new ObservableCollection<ClientInvoice>(((ObservableCollection<ClientInvoice>)vm.InvoicesShadow).Where(i => i.Date.Year
                                                                               == e.Year));
                }
                else if (e.Month > 0 && e.Year < 1)
                {
                    vm.Invoices = new ObservableCollection<ClientInvoice>(((ObservableCollection<ClientInvoice>)vm.InvoicesShadow).Where(i => i.Date.Month == e.Month));
                }
                else
                    vm.Invoices = new ObservableCollection<ClientInvoice>(((ObservableCollection<ClientInvoice>)vm.InvoicesShadow));


                await SetTotals<ClientInvoice>(vm.Invoices);
                currentContext.Post(_ =>
                {
                    DcInvoice.TotalAmount = TotalAmount.ToString();
                    DcInvoice.TotalVatValue = TotalVatValue.ToString();
                }, null);
                   
           
                
            }
            else
            {
                if (e.Month > 0 && e.Year > 0)
                    vm.Invoices = new ObservableCollection<SupplierInvoice>(((ObservableCollection<SupplierInvoice>)vm.InvoicesShadow).Where(i => i.Date.Month == e.Month && i.Date.Year
                                                                               == e.Year));
                else if (e.Year > 0 && e.Month < 1)
                {
                    vm.Invoices = new ObservableCollection<SupplierInvoice>(((ObservableCollection<SupplierInvoice>)vm.InvoicesShadow).Where(i => i.Date.Year
                                                                               == e.Year));
                }
                else if (e.Month > 0 && e.Year < 1)
                {
                    vm.Invoices = new ObservableCollection<SupplierInvoice>(((ObservableCollection<SupplierInvoice>)vm.InvoicesShadow).Where(i => i.Date.Month == e.Month));
                }
                else
                    vm.Invoices = new ObservableCollection<SupplierInvoice>(((ObservableCollection<SupplierInvoice>)vm.InvoicesShadow));

                await SetTotals<SupplierInvoice>(vm.Invoices);
                currentContext.Post(_ =>
                {
                    DcInvoice.TotalAmount = TotalAmount.ToString();
                    DcInvoice.TotalVatValue = TotalVatValue.ToString();
                }, null);
            }
                
        }

        public async Task SetTotals<T>(object collection)
            where T:class,new ()
        {
          try
            {
                decimal totalVatValues = 0;
                decimal totalAmount = 0;
                foreach (var item in (collection as ObservableCollection<T>))
                {
                    totalVatValues += ((dynamic)item).VatValue;
                    totalAmount += ((dynamic)item).TotalAmount;
                }
               await Dispatcher.BeginInvoke(new Action(() =>
                {
                    TotalVatValue = totalVatValues;
                    TotalAmount = totalAmount;
                }));
               

            }
            catch { }


        }

    }
}
