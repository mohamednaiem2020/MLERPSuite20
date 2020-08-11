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
        public virtual ICollection<AdminCoding> Codings { get; set; }
        public virtual ICollection<AdminWFDocument> WFDocuments { get; set; }
        public virtual ICollection<AdminWFStep> WFSteps { get; set; }
        public virtual ICollection<AdminWFTransList> WFTransList { get; set; }
        [Required]
        public int ModuleId { get; set; }
        public virtual AdminModule Module { get; set; }
        [Required]
        public int ScreenId { get; set; }
        public virtual AdminScreen Screen { get; set; }
        #endregion
    }
}
