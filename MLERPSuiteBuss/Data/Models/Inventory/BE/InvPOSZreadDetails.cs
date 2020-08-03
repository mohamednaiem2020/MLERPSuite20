using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int ZreadId { get; set; }
        [ForeignKey("InvPOSSalesPaymentMethod"), Column(Order = 0)]
        [Required]
        public int PaymentMethodIdTenantId { get; set; }
        [ForeignKey("InvPOSSalesPaymentMethod"), Column(Order = 1)]
        [Required]
        public int PaymentMethodId { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
    
        #endregion
    }
}
