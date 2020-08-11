using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminScreen
    {
        #region Constructor
        public AdminScreen()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int ScreenId { get; set; }
        public virtual ICollection<AdminModuleScreen> ModuleScreens { get; set; }
        public virtual ICollection<AdminScreen> Screens { get; set; }
        public virtual ICollection<AdminScreenLanguage> ScreenLanguage { get; set; }
        public virtual ICollection<AdminWFMaster> WFMaster { get; set; }
        [Required]
        public int RightId { get; set; }
        public virtual AdminRight Right { get; set; }
        [Required]
        public string ModuleId { get; set; }
        public virtual AdminModule Module { get; set; }
        public int ScreenParentId { get; set; }
        public virtual AdminScreen Screen { get; set; }
        [Required]
        public int ScreenLevelId { get; set; }
        public virtual AdminScreenLevel ScreenLevel { get; set; }
        [Required]
        public int ScreenLevelId1 { get; set; }
        public int ScreenLevelId2 { get; set; }
        public int ScreenLevelId3 { get; set; }
        public int ScreenLevelId4 { get; set; }
        [Required]
        public byte ScreenIsLeaf { get; set; }
        [DefaultValue(0)]
        [Required]
        public int ScreenOrder { get; set; }
        [Required]
        public string ScreenURL { get; set; }
        public string ScreenMode { get; set; }
        [Required]
        public string ScreenIcon { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsDisabled { get; set; }
        #endregion
    }
}
