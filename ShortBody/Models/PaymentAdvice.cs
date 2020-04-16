using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BaseClasses;

namespace ShortBody.Models
{
    public class PaymentAdvice :ObservableObject
    {
        private List<Advice> advices;
        private double vatrate;
        private decimal vatvalue;
        private decimal totalAmount;
        private string bankName;

        public PaymentAdvice()
        {
            advices = new List<Advice>();
        }
        public int PaymentAdviceId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string ChequeNumber { get; set; }

        public string CompanyName { get; set; }

        public string BankName
        {
            get { return bankName; }
            set { bankName = value;OnPropertyChanged(); }
        }

       // public decimal Amount { get; set; }
        public double VatRate
        {
            get { return vatrate; }
            set { vatrate = value;OnPropertyChanged(); }
        }


        public decimal VatValue
        {
            get { return vatvalue; }
            set { vatvalue = value;OnPropertyChanged(); }
        }
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value;OnPropertyChanged(); }
        }

        public string IssuedBy { get; set; }

        [AutoHideColumn]
        public virtual List<Advice> Advices { get { return advices; }set { advices = value; OnPropertyChanged(); } }


        [AutoHideColumn]
        public int CompanyId { get; set; }

        [AutoHideColumn]
        [ForeignKey("CompanyId")]
        public Company AssociatedCompany { get; set; }
    }
}
