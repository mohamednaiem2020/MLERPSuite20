using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminTenant
    {
        [Key]
        [Required]
        public int TenantId { get; set; }
        [Required]
        public string TenantDescription { get; set; }
        public virtual ICollection<AdminActor> Actors { get; set; }
        public virtual ICollection<AdminChart> Charts { get; set; }
    }
}
