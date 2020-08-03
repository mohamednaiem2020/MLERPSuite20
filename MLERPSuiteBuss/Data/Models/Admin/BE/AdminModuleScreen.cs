using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminModuleScreen
    {
        #region Constructor
        public AdminModuleScreen()
        {
        }
        #endregion
        #region Properties
        [Key]
        [Required]
        [ForeignKey("AdminModule")]
        public int ModuleId { get; set; }
        [Key]
        [Required]
        [ForeignKey("AdminScreen")]
        public int ScreenId { get; set; }
        #endregion
    }
}
