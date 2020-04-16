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
    public class Supplier
    {
        public Supplier()
        {
            Invoices = new List<SupplierInvoice>();
        }

        [AutoHideColumn]
        public int SupplierId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Phone { get; set; }

        //Associations
        [AutoHideColumn]
        public virtual List<SupplierInvoice> Invoices { get; set; }

        [AutoHideColumn]
        public int CompanyId { get; set; }

        [AutoHideColumn]
        [ForeignKey("CompanyId")]
        public virtual Company AssociatedCompany { get; set; }
    }
}
