
using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for QuotationsReport.xaml
    /// </summary>
    public partial class QuotationsReport : Window
    {
        QuotationViewModel vm;
        string QuoteFor;
        decimal TotalVatValue = 0;
        decimal TotalAmount = 0;
        SynchronizationContext currentContext;

        /// <summary>
        /// Initialize a new Quotation Report
        /// </summary>
        /// <param name="quoteFor">Specify the particular quotations that you are Reporting on
        /// All for allClients and Client for a particular client</param>
        /// <param name="viewModel">The ViewModel where all data is taken from</param>
        /// <param name="_who">Specifies who the quotation is for to be displayed on the form</param>
        public QuotationsReport(string quoteFor,QuotationViewModel viewModel,string _who)
        {
            InitializeComponent();
            DataContext = viewModel;
            vm = viewModel;
            DcQutations.Who = _who;
            DcQutations.DateChanged += DcQutations_DateChanged;
            currentContext = SynchronizationContext.Current;
            QuoteFor = quoteFor;
            DcQutations.Month = 0;
        }

        private async void DcQutations_DateChanged(object sender,DateEventArgs e)
        {
            try
            {
                //check if the selected date is null and return all Quotations
                if (e.Date != null)
                {
                    //check if the demanded quotations if for all
                    if (QuoteFor == "All")
                    {
                        if (e.Month > 0 && e.Year > 0)
                            vm.ReportedQuotation = new ObservableCollection<Quotation>(vm.allQuotations.Where(i => i.QuoteDate.Month == e.Month && i.QuoteDate.Year
                                                                                       == e.Year));
                        else if (e.Year > 0 && e.Month < 1)
                        {
                            vm.ReportedQuotation = new ObservableCollection<Quotation>(vm.allQuotations.Where(i => i.QuoteDate.Year
                                                                                       == e.Year));
                        }
                        else if (e.Month > 0 && e.Year < 1)
                        {
                            vm.ReportedQuotation = new ObservableCollection<Quotation>(vm.allQuotations.Where(i => i.QuoteDate.Month == e.Month));
                        }


                    }

                    else
                    {
                        if (e.Month > 0 && e.Year > 0)
                            vm.ReportedQuotation = new ObservableCollection<Quotation>(vm.ClientQuotation.Where(i => i.QuoteDate.Month == e.Month && i.QuoteDate.Year
                                                                                       == e.Year));
                        else if (e.Year > 0 && e.Month < 1)
                        {
                            vm.ReportedQuotation = new ObservableCollection<Quotation>(vm.ClientQuotation.Where(i => i.QuoteDate.Year
                                                                                       == e.Year));
                        }
                        else if (e.Month > 0 && e.Year < 1)
                        {
                            vm.ReportedQuotation = new ObservableCollection<Quotation>(vm.ClientQuotation.Where(i => i.QuoteDate.Month == e.Month));
                        }


                    }


                }
                else
                {
                    if (QuoteFor == "All")
                        vm.ReportedQuotation = new ObservableCollection<Quotation>(vm.allQuotations);
                    else
                        vm.ReportedQuotation = new ObservableCollection<Quotation>(vm.ClientQuotation);
                }

                await SetTotals<Quotation>(vm.ReportedQuotation);
                currentContext.Post(_ =>
                {
                    DcQutations.TotalAmount = TotalAmount.ToString();
                    DcQutations.TotalVatValue = TotalVatValue.ToString();
                }, null);
            }
            catch { }
            
        }

        public async Task SetTotals<T>(object collection)
            where T : class, new()
        {
            try
            {
                decimal totalVatValues = 0;
                decimal totalAmount = 0;
                foreach (var item in (collection as ObservableCollection<T>))
                {
                    totalVatValues += (decimal)((dynamic)item).VatValue;
                    totalAmount += (decimal)((dynamic)item).TotalAmount;
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
