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
    public class QuotationItem : ObservableObject
    {
        private double totalCost;
            private string unitCost;
        private string qty;

        [AutoHideColumn]
        public int Id { get; set; }

        public string QTY { get { return qty; }set { qty = value; OnPropertyChanged(); } }

        public string Description { get; set; }

        public string UnitCost { get { return unitCost; }set { unitCost = value; OnPropertyChanged(); } }

        public double TotalCost { get { return totalCost; }set { totalCost = value; OnPropertyChanged(); } }


        //Associations
        [AutoHideColumn]
        public int QuotationId { get; set; }

        [AutoHideColumn]
        [ForeignKey("QuotationId")]
        public virtual Quotation Quotation{get;set;}

      
    }
}
