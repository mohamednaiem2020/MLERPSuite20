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
        [Required]
        public int ScreenId { get; set; }
        [Required]
        [ForeignKey("AdminRight")]
        public int RightId { get; set; }
        [Required]
        [ForeignKey("AdminModule")]
        public string ModuleId { get; set; }
        [ForeignKey("AdminScreen")]
        public int ScreenParentId { get; set; }
        [Required]
        public int ScreenLevelId { get; set; }
        [Required]
        public int ScreenLevelId1 { get; set; }
        public int ScreenLevelId2 { get; set; }
        public int ScreenLevelId3 { get; set; }
        public int ScreenLevelId4 { get; set; }
        [Required]
        public int ScreenIsLeaf { get; set; }
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
