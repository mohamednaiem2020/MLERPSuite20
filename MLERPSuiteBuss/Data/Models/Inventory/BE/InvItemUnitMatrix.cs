using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvItemUnitMatrix
    {
        #region Constructor
        public InvItemUnitMatrix()
        {
        }
        #endregion

        #region Properties
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        [Key, Column(Order = 1)]
        public int ItemId { get; set; }
        [Key, Column(Order = 2)]
        public int UnitIdFrom { get; set; }
        public virtual InvItemUnit ItemUnitFrom { get; set; }

        [Key, Column(Order = 3)]
        public int UnitIdTo { get; set; }
        public virtual InvItemUnit ItemUnitTo{ get; set; }

        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal Factor { get; set; }
        #endregion
    }
}
