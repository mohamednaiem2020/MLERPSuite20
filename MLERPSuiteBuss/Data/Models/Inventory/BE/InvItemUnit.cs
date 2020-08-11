using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int ItemId { get; set; }
        [Key]
        [Required]
        public int UnitId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal FactorToBaseUnit { get; set; }
        public byte IsBaseUnit { get; set; }
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
