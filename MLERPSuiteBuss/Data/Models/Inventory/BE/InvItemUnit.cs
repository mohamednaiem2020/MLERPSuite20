using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvItemUnit
    {
        #region Constructor
        public InvItemUnit()
        {
        }
        #endregion

        #region Properties
       
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
         
        public int ItemId { get; set; }
        
        public int UnitId { get; set; }
        
        public virtual ICollection<InvItemUnitBarcode> ItemUnitBarcodes { get; set; }
        public virtual ICollection<InvItemUnitMatrix> ItemUnitMatrixesFrom { get; set; }
        public virtual ICollection<InvItemUnitMatrix> ItemUnitMatrixesTo { get; set; }
        public virtual ICollection<InvPriceDetails> PriceDetails { get; set; }
        public virtual ICollection<InvPOSSalesDetails> POSSalesDetails { get; set; }
        public virtual ICollection<InvPOSReturnDetails> POSReturnDetails { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal FactorToBaseUnit { get; set; }
        [Required]
        [DefaultValue(0)]
        public byte IsBaseUnit { get; set; }
        [Required]
        [DefaultValue(0)]
        public byte IsDisabled { get; set; }
      
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
