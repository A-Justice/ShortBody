using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BaseClasses;

namespace ShortBody.Models
{
   public class Quotation :ObservableObject
    {
        private decimal amount;
        private decimal vatValue;
        private decimal totalAmount;
        private decimal vat_Nhil;
        private ObservableCollection<QuotationItem> items;
        private int quoteNumber;

        public  Quotation()
        {
      
            items = new ObservableCollection<QuotationItem>();
            
        }
        [AutoHideColumn]
        public int QuotationId { get; set; }

        public int QuoteNumber
        {
            get { return quoteNumber; }
            set
            {
                quoteNumber = value;
                OnPropertyChanged();
            }
        }

        public DateTime QuoteDate { get; set; }

        public string Requester { get; set; }

        public string ServiceWanted { get; set; }

        public string ProjectSite { get; set; }


        [DataType(DataType.Currency)]
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                OnPropertyChanged();
            }
        }


        public decimal Vat_Nhil
        {
            get { return vat_Nhil; }
            set { vat_Nhil = value;OnPropertyChanged(); }
        }

        public decimal VatValue {
            get { return vatValue; }
            set { vatValue = value;OnPropertyChanged(); }
        }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:n}")]
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value;OnPropertyChanged(); }
        }


        public string Remarks { get; set; }


        public string JobStatus { get; set; }

        //Quote Report field Values
        [AutoHideColumn]
        public string QuoteTerms { get; set; }

        [AutoHideColumn]
        public string Miscellenous { get; set; }

        [AutoHideColumn]
        public string WOD { get; set; }
        [AutoHideColumn]
        public string LPO { get; set; }

        [AutoHideColumn]
        public string Others { get; set; }

        [AutoHideColumn]
        public string IssuedBy { get; set; }

        //Foreign key columns

        [AutoHideColumn]
        public int ClientId { get; set; }

        [AutoHideColumn]
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [AutoHideColumn]
        public virtual ObservableCollection<QuotationItem> Items {
            get { return items; }
            set { items = value;OnPropertyChanged(); }
        }

       
    }
}
