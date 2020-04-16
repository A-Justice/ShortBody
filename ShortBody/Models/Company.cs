using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BaseClasses;

namespace ShortBody.Models
{
   public class Company :ObservableObject
    {
        private List<CompanyAccountDetail> accountDetails;

        public Company()
        {
            Clients = new List<Client>();

        Suppliers= new List<Supplier>();

            Expenses = new List<Expense>();

            Incomes = new List<Income>();

            Operations = new List<Operation>();

            AccountDetails = new List<CompanyAccountDetail>();
        }
        [AutoHideColumn]
        public int CompanyId { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }


        public string Slogan { get; set; }

        [AutoHideColumn]
        [MaxLength]
        public byte[] Logo { get; set; }


        //Associations
        [AutoHideColumn]
        public virtual List<Operation> Operations { get; set; }

        [AutoHideColumn]
        public virtual List<CompanyAccountDetail> AccountDetails
        {
            get { return accountDetails; }
            set { accountDetails = value;OnPropertyChanged(); }
        }

        [AutoHideColumn]
        public virtual List<Client> Clients { get; set; }
        [AutoHideColumn]
        public virtual List<PaymentAdvice> PaymentAdvices { get; set; }

        [AutoHideColumn]
        public virtual List<Supplier> Suppliers { get; set; }

        [AutoHideColumn]
        public virtual List<Expense> Expenses { get; set; }

        [AutoHideColumn]
        public virtual List<Income> Incomes { get; set; }
    }
}
