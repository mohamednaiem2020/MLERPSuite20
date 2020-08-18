using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSZreadDetails
    {
        #region Constructor
        public InvPOSZreadDetails()
        {
        }
        #endregion

        #region Properties
     
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
       
        public int ZreadId { get; set; }
      
        public int PaymentMethodId { get; set; }
        
        
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
    
        #endregion
    }
}
