using ShortBody.Enums;
using ShortBody.Pages;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortBody.ValueConverters
{
    public class DashBoardPageConverter : BaseConverter<DashBoardPageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (LoginPage.IsLoggedOut)
            {
                ClientPage.clientPage = null;
                InvoicePage.invoicePage = null;
                QuotationPage.quotationPage = null;
                SupplierPage.supplierPage = null;
                ExpensePage.expensePage = null;
                IncomePage.incomePage = null;
                CompanyPage.companyPage = null;
                UsersPage.usersPage = null;
                PaymentAdvicePage.paymentAdvicePage = null;
                LoginPage.IsLoggedOut = false;
            }

            switch ((DashBoardPages)value)
            {
                case DashBoardPages.clientPage:
                    DashBoard.dashBoard.TopHeader.Text = "CLIENTS";
                    if (ClientPage.clientPage != null )
                    {
                        //((dynamic)(ClientPage.clientPage.DataContext)).AllClients = DashBoardViewModel.allClients;
                      
                        return ClientPage.clientPage;
                        
                    }
                    return  new ClientPage();
                case DashBoardPages.InvoicePage:
                    DashBoard.dashBoard.TopHeader.Text = "INVOICES";
                    if (InvoicePage.invoicePage != null )
                    {
                        ((dynamic)(InvoicePage.invoicePage.DataContext)).AllClients = ClientPageViewModel.allClients;
                       
                        return InvoicePage.invoicePage;
                    }

                    return new InvoicePage();
                case DashBoardPages.QuotationPage:
                    DashBoard.dashBoard.TopHeader.Text = "QUOTATIONS";
                    if (QuotationPage.quotationPage != null )
                    {
                        ((dynamic)(QuotationPage.quotationPage.DataContext)).AllClients = ClientPageViewModel.allClients;
                        
                        return QuotationPage.quotationPage;
                    }
                    return QuotationPage.quotationPage?? new QuotationPage();
                case DashBoardPages.SuppliersPage:
                    DashBoard.dashBoard.TopHeader.Text = "SUPPLIERS";
                    if (SupplierPage.supplierPage != null )
                        return SupplierPage.supplierPage;
                    return new SupplierPage();
                  
                case DashBoardPages.EspensePage:
                    DashBoard.dashBoard.TopHeader.Text = "EXPENSES";
                    if (ExpensePage.expensePage != null )
                        return ExpensePage.expensePage;
                    return new ExpensePage();

                case DashBoardPages.IncomePage:
                    DashBoard.dashBoard.TopHeader.Text = "INCOMES";
                    if (IncomePage.incomePage != null )
                        return IncomePage.incomePage;     
                    return new IncomePage();

                case DashBoardPages.CompaniesPage:
                    DashBoard.dashBoard.TopHeader.Text = "COMPANIES";
                    if (CompanyPage.companyPage != null )
                        return CompanyPage.companyPage;
                    return new CompanyPage();

                case DashBoardPages.UsersPage:
                    DashBoard.dashBoard.TopHeader.Text = "USERS";
                    if (UsersPage.usersPage != null)
                        return UsersPage.usersPage;
                    return new UsersPage();

                case DashBoardPages.PaymentAdvicePage:

                    DashBoard.dashBoard.TopHeader.Text = "PAYMENT ADVICES";
                    if (PaymentAdvicePage.paymentAdvicePage != null)
                        return PaymentAdvicePage.paymentAdvicePage;
                    return new PaymentAdvicePage();

            }
            
            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
