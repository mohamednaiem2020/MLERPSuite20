using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int ReturnInvoiceId { get; set; }
        [Key]
        [Required]
        public int DetailsId { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int UnitId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DetailsGuidId { get; set; }
        #endregion
    }
}
