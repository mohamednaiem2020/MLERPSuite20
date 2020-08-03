using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminPackageModule
    {
        #region Constructor
        public AdminPackageModule()
        {
        }
        #endregion
        #region Properties
        [Key]
        [Required]
        [ForeignKey("AdminPackage")]
        public int PackageId { get; set; }
        [Key]
        [Required]
        [ForeignKey("AdminModule")]
        public int ModuleId { get; set; }
      
       
        #endregion
    }
}
