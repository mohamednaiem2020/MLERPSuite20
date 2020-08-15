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
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        [Key, Column(Order = 1)]
        public int ZreadId { get; set; }
        public virtual InvPOSZread POSZread { get; set; }
        [Key, Column(Order = 2)]
        public int PaymentMethodId { get; set; }
        public virtual InvPOSSalesPaymentMethod POSSalesPaymentMethod { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
    
        #endregion
    }
}
