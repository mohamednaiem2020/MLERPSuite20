using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvItemUnitOfMeasurement
    {
        #region Constructor
        public InvItemUnitOfMeasurement()
        {
        }
        #endregion
        #region Properties
    
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
       
        [Required]
        public int UnitId { get; set; }
        public virtual ICollection<InvItemUnit> ItemUnits { get; set; }
        [Required]
        public string UnitCode { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public int EditedBy { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
