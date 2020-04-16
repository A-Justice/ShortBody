using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ShortBody.Reports
{
    /// <summary>
    /// Interaction logic for IncomeReport.xaml
    /// </summary>
    public partial class IncomeReport : Window
    {
        EIviewModel vm;
        public IncomeReport(EIviewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            DcIncomes.DateChanged += DcIncomes_DateChanged;
            vm = viewModel;
        }

        private void DcIncomes_DateChanged(object sender, DateEventArgs e)
        {
            if (e.Date != null)
            {
                if (e.Month > 0 && e.Year > 0)
                    vm.AllIncomes = new ObservableCollection<Income>(vm.AllIncomesShadow.Where(i => i.Date.Month == e.Month && i.Date.Year
                                                                               == e.Year));
                else if (e.Year > 0 && e.Month < 1)
                {
                    vm.AllIncomes = new ObservableCollection<Income>(vm.AllIncomesShadow.Where(i => i.Date.Year
                                                                               == e.Year));
                }
                else if (e.Month > 0 && e.Year < 1)
                {
                    vm.AllIncomes = new ObservableCollection<Income>(vm.AllIncomesShadow.Where(i => i.Date.Month == e.Month));
                }
            }
            else
            {
                vm.AllIncomes = new ObservableCollection<Income>(vm.AllIncomesShadow);
            }
        }
    }
}
