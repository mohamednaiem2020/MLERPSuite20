using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSReturnDetails
    {
        #region Constructor
        public InvPOSReturnDetails()
        {
        }
        #endregion

        #region Properties
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        [Key, Column(Order =1)]
        public int ReturnInvoiceId { get; set; }
      
        [Key, Column(Order = 2)]
        public int DetailsId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
       
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DetailsGuidId { get; set; }
        #endregion
    }
}
