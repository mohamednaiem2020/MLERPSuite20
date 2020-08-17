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
        
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        
        public int ItemId { get; set; }
        
        public int UnitIdFrom { get; set; }
      
        
        public int UnitIdTo { get; set; }
     
        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal Factor { get; set; }
        #endregion
    }
}
