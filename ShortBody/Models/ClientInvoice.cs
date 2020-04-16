using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortBody.Models
{
    public class ClientInvoice
    {
        [AutoHideColumn]
        public int ClientInvoiceId { get; set; }

        public string Invoice_No { get; set; }

        public DateTime Date { get; set; }

        public string PurchaseOrder_No{ get; set; }

        public string ProjectSite { get; set; }

        public string WayBill_No { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        public decimal Vat_Nhil { get; set; }

        [DataType(DataType.Currency)]
        public decimal VatValue { get; set;}

        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }



        public string Remarks { get; set; }

        

        //Associations
        [AutoHideColumn]
        public int ClientId { get; set; }

        [AutoHideColumn]
        [ForeignKey("ClientId")]
        public virtual Client supplier { get; set; }
    }
}
