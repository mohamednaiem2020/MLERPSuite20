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
    public class InvItemUnitBarcode
    {
        #region Constructor
        public InvItemUnitBarcode()
        {
        }
        #endregion

        #region Properties
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        [Key, Column(Order = 1,TypeName = "nchar")]
        [Required]
        [StringLength(30)]
        public string Barcode { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int UnitId { get; set; }
        public virtual InvItemUnit ItemUnit { get; set; }

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
