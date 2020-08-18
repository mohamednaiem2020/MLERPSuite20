using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminPackage
    {
        #region Constructor
        public AdminPackage()
        {
        }
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackageId { get; set; }
        public virtual ICollection<AdminPackageModule> PackageModules { get; set; }
        public virtual ICollection<AdminTenantPackage> TenantPackage { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal PackageMonthlyPrice { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal PackageYearlyPrice { get; set; }
        
        [Required]
        public int DemoForMonthCount { get; set; }
        
        [Required]
        public byte IsFree { get; set; }
        #endregion
    }
}
