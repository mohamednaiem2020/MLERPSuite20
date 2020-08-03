using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPriceDetails
    {
        #region Constructor
        public InvPriceDetails()
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
        [ForeignKey("InvPriceHeader")]
        public int PriceListId { get; set; }
        [Key]
        [Required]
        public int PriceListDetailsId { get; set; }
        [Key]
        [Required]
        [ForeignKey("InvItemUnit"), Column(Order = 0)]
        public int ItemId { get; set; }
        [Key]
        [Required]
        [ForeignKey("InvItemUnit"), Column(Order = 1)]
        public int UnitId { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        #endregion
    }
}
