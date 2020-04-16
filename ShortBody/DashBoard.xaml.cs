using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.Pages;
using ShortBody.Resources.UserControls;
using ShortBody.UViewModels;
using ShortBody.Windows;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShortBody
{
    /// <summary>
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : UserControl
    {
        bool opened;
        LinedButton previousButton;
        DashBoardViewModel viewModel;
        public static DashBoard dashBoard;
        public static event EventHandler UnpaidQuotationCountChanged;
        public static AppContext db1;
        public DashBoard()
        {
            InitializeComponent();
            opened = false;
            viewModel = new DashBoardViewModel();
            this.DataContext = viewModel;
            previousButton = btnShowClients;
            UnpaidQuotationCountChanged += DashBoardViewModel_UnpaidQuotationCountChanged;

            OnUnpaidQuotationChanged();
            dashBoard = this;
        }

        private void btnSideNavToggler_Click(object sender, RoutedEventArgs e)
        {
            
            PaneAnimation(opened);

            if (opened)
                opened = false;
            else
                opened = true;
        }


        public void PaneAnimation(bool opened)
        {
            int from,to;
            if (opened)
            {
                from = 155;
                to = 45;
            }
            else
            {
                from = 45;
                to = 155;
            }
         

            var sb = new Storyboard();

            var da = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(.5)),
                DecelerationRatio = 0.9f
            };

            Storyboard.SetTargetProperty(da, new PropertyPath("Width"));
            sb.Children.Add(da);
            sb.Begin(SideNav);
        }

        private void LinedButton_Click(object sender, RoutedEventArgs e)
        {
            
            LinedButton currentButton = sender as LinedButton;


            try
            {
                MasterPasswordWindow mWindow =null;

                if (currentButton.Name == "btnCompanies")
                {
                    mWindow = new MasterPasswordWindow(DashBoardPages.CompaniesPage);
                    
                }
                else if (currentButton.Name == "btnUsers")
                {
                    mWindow= new MasterPasswordWindow(DashBoardPages.UsersPage);
                }

                if (mWindow.ShowDialog() == true)
                {
                    previousButton.ShowLine = false;

                    currentButton.ShowLine = true;

                    previousButton = currentButton;
                    return;
                }
                else
                    return;

            }
            catch {
            }



            previousButton.ShowLine = false;

            currentButton.ShowLine = true;

            previousButton = currentButton;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow.Footer.Visibility = Visibility.Visible;
        }

        private async void DashBoardViewModel_UnpaidQuotationCountChanged(object sender, EventArgs e)
        {
            int tempNumber = 0;
            await Task.Run(() => {

                tempNumber = new AppContext().Quotations.ToList().Where(i =>i.Client.CompanyId == viewModel.SelectedCompany.CompanyId && i.Remarks == "UnPaid").Count();

            });

            if (tempNumber != 0)
                QuotationNotification.Count = tempNumber.ToString();
            else if (tempNumber == 0)
                QuotationNotification.Count = "";
        }

        private void StackPanel_Unloaded(object sender, RoutedEventArgs e)
        {
            viewModel.db.SaveChanges();
        }

        private void QuotationNotification_Click(object sender, RoutedEventArgs e)
        {
            LinedButton_Click(btnQuotation, null);
            viewModel.DashBoardPage = DashBoardPages.QuotationPage;
            QuotationPage.quotationPage.viewModel.SearchBy = "Remarks";
            QuotationPage.quotationPage.viewModel.SearchString = "UnPaid";
          
            try
            {
                if (db1 != null)
                    viewModel.SaveSearch(ref db1);

                db1 = new AppContext();
                QuotationPage.quotationPage.viewModel.SearchQuotation(db1.Clients.Where(i=>i.CompanyId == viewModel.SelectedCompany.CompanyId).ToList(),
                new AppContext().Clients.Where(i => i.CompanyId == viewModel.SelectedCompany.CompanyId).ToList());
            }
            finally { }
            
           
        }


        public void OnUnpaidQuotationChanged()
        {
            UnpaidQuotationCountChanged.Invoke(null, null);
        }
    }
}
