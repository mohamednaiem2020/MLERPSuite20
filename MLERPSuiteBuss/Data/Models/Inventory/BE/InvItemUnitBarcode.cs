using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvItemUnitBarcode
    {
        #region Constructor
        public InvItemUnitBarcode()
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
        [Column(TypeName = "nchar")]
        [StringLength(30)]
        public string Barcode { get; set; }
        [ForeignKey("InvItemUnit"), Column(Order = 0)]
        [Required]
        public int ItemUnitTenantId { get; set; }
        [ForeignKey("InvItemUnit"), Column(Order = 1)]
        [Required]
        public int ItemId { get; set; }
        [ForeignKey("InvItemUnit"), Column(Order = 2)]
        [Required]
        public int UnitId { get; set; }
       
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
