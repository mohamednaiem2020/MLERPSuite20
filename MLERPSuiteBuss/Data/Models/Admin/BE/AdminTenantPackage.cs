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
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        [ForeignKey("AdminPackage")]
        public int PackageId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal LastPrice { get; set; }
        #endregion
    }
}
