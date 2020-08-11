using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminModule
    {
        #region Constructor
        public AdminModule()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int ModuleId { get; set; }
        public virtual ICollection<AdminModuleScreen> ModuleScreens { get; set; }
        public virtual ICollection<AdminPackageModule> PackageModules { get; set; }
        public virtual ICollection<AdminScreen> Screens { get; set; }
        public virtual ICollection<AdminModule> Modules { get; set; }
        [Required]
        public string ModuleCode { get; set; }
        [Required]
        public int ModuleOrder { get; set; }
        [Required]
        public string ModuleURL { get; set; }
        [Required]
        public string ModuleIcon { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsDisabled { get; set; }
        #endregion
    }
}
