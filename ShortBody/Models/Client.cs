using ShortBody.Resources.Helper_Methods;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.BaseClasses;

namespace ShortBody.Models
{
    public class Client 
    {
      
        public Client()
        {
            Quotations = new List<Quotation>();
            Invoices = new List<ClientInvoice>();
            
        }

        [AutoHideColumn]
        public int ClientId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        

        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

      


        //Associations

         [AutoHideColumn]
        public virtual List<Quotation> Quotations{ get; set; }

        [AutoHideColumn]
        public virtual List<ClientInvoice> Invoices { get; set; }



        [AutoHideColumn]
        public int CompanyId { get; set; }

        [AutoHideColumn]
        [ForeignKey("CompanyId")]
        public Company AssociatedCompany { get; set; }
    }
}