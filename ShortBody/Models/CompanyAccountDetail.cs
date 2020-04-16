using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortBody.Models
{
   public class CompanyAccountDetail
    {
        [AutoHideColumn]
        public int CompanyAccountDetailId { get; set; }

        public string AccountName { get; set; }

        public string BankName { get; set; }
        public string AccountNumber { get; set; }

        public string BankBranch { get; set; }

        //Foreign keys
        [AutoHideColumn]
        public int CompanyId { get; set; }

        [AutoHideColumn]
        [ForeignKey("CompanyId")]
        public virtual Company AssociatedCompany { get; set; }
    }
}
