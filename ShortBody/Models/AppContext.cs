using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortBody.Models
{
    public class AppContext :DbContext
    {
        static AppContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppContext>());
           
        }
        public AppContext():base("DefaultConnection")
        {
            
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientInvoice> ClientInvoices { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyAccountDetail> CompanyAccountDetails { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<SupplierInvoice> SupplierInvoices { get; set; }

        public DbSet<QuotationItem> QuotationItems { get; set; }

        public DbSet<MasterPassword> MasterPasswords { get; set; }

        public DbSet<PaymentAdvice> PaymentAdvices { get; set; }

        public DbSet<Advice> Advices { get; set; }
    }
}
