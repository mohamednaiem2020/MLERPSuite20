using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminTenantPackage
    {
        #region Constructor
        public AdminTenantPackage()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        [Key]
        public int PackageId { get; set; }
        public virtual AdminPackage Package { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal LastPrice { get; set; }
        #endregion
    }
}
