using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvItemUnitMaxtrix
    {
        #region Constructor
        public InvItemUnitMaxtrix()
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
        public int UnitIdFrom { get; set; }
        [Key]
        [Required]
        public int UnitIdTo { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal Factor { get; set; }
        #endregion
    }
}
