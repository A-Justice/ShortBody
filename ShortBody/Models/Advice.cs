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
    public class Advice :ObservableObject
    {
        private string invoiceNumber;
        private DateTime adviceDate = DateTime.Now;
        private string description;
        private string amount;
        private string remarks;

        public int AdviceId { get; set; }
        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; OnPropertyChanged(); }
        }

        public DateTime AdviceDate
        {
            get
            {
                return adviceDate;
            }
            set
            {
                adviceDate = value;
                OnPropertyChanged();
            }
        }

        public string Description 
            {
            get { return description; }
            set { description = value;OnPropertyChanged(); }
        }

        public string Amount
        {
            get { return amount; }
            set { amount = value;OnPropertyChanged(); }
        }

        public string Remarks
        {
            get { return remarks; }
            set
            {
                remarks = value;
                OnPropertyChanged();
            }
        }


        //Associations
        [AutoHideColumn]
        public int PaymentAdviceId { get; set; }

        [AutoHideColumn]
        [ForeignKey("PaymentAdviceId")]
        public virtual PaymentAdvice PaymentAdvice { get; set; }
    }
}
