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
    public class Income : ObservableObject
    {
     
        public Income()
        {
           
        }
        [AutoHideColumn]
        public int IncomeId { get; set; }

        public DateTime Date { get; set; }

        public string Payee { get; set; }

        public string ChequeNumber { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        //fk
        [AutoHideColumn]
        public int CompanyId { get; set; }

        [AutoHideColumn]
        [ForeignKey("CompanyId")]
        public virtual Company AssociatedCompany { get; set; }




    }
}
