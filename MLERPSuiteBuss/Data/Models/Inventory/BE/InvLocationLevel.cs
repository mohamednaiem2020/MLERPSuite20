using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvLocationLevel
    {
        #region Constructor
        public InvLocationLevel()
        {
        }
        #endregion
        #region Properties
       
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

       
        public int LocationLevelId { get; set; }
        public virtual ICollection<InvLocation> Locations { get; set; }

        [DefaultValue(1)]
        [Required]
        public int LocationCodeLength { get; set; }
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
