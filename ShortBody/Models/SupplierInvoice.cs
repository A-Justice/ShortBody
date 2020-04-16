using ShortBody.Resources.Helper_Methods;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortBody.Models
{
    public class SupplierInvoice
    {
        [AutoHideColumn]
        public int SupplierInvoiceId { get; set; }

        public string Invoice_No { get; set; }

        public DateTime Date { get; set; }

        public string PurchaseOrder_No { get; set; }

        public string ProjectSite { get; set; }

        public string WayBill_No { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        public decimal Vat_Nhil { get; set; }

        [DataType(DataType.Currency)]
        public decimal VatValue { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }

        public string Remarks { get; set; }
        

        //Associations
        [AutoHideColumn]
        public virtual int SupplierId { get; set; }

        [AutoHideColumn]
        [ForeignKey("SupplierId")]
        public virtual Supplier  supplier { get; set; }


    }
}