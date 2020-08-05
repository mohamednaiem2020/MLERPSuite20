using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminActor
    { 
        #region Constructor
        public AdminActor()
        {
        }
        #endregion

        #region Properties
        [Key, Column(Order = 0)]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public int ActorId { get; set; }
    
        #endregion
    }
}
