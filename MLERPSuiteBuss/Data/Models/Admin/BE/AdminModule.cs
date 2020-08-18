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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModuleId { get; set; }
        public virtual ICollection<AdminModuleScreen> ModuleScreens { get; set; }
        public virtual ICollection<AdminPackageModule> PackageModules { get; set; }
        public virtual ICollection<AdminWFMaster> WFMasters { get; set; }
        [Required]
        public string ModuleCode { get; set; }
        [Required]
        public int ModuleOrder { get; set; }
        [Required]
        public string ModuleURL { get; set; }
        [Required]
        public string ModuleIcon { get; set; }
        
        [Required]
        public byte IsDisabled { get; set; }
        [Required]
        public int Records3DigitsPrefix { get; set; }
        #endregion
    }
}
