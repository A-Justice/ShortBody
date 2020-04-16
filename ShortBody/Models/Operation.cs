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
   public class Operation
    {
        [AutoHideColumn]
        public int OperationId { get; set; }


        public string OperationName { get; set; }

        public string OperationDescription { get; set; }

        [DataType(DataType.Currency)]
        public decimal EstimateAmount { get; set; }

        //Foreign keys
        [AutoHideColumn]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]

        [AutoHideColumn]
        public virtual Company AssociatedCompany { get; set; }
    }
}
