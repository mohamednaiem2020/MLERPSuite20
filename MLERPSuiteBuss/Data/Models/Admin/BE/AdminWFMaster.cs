using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWFMaster
    {
        #region Constructor
        public AdminWFMaster()
        {
        }
        #endregion

        #region Properties
        [Key]
        [Required]
        public int WorkFlowId { get; set; }
        [Required]
        [ForeignKey("AdminModule")]
        public int ModuleId { get; set; }
        [Required]
        [ForeignKey("AdminScreen")]
        public int ScreenId { get; set; }
        #endregion
    }
}
