using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWFStepStatus
    {
        #region Constructor
        public AdminWFStepStatus()
        {
        }
        #endregion

        #region Properties
        [Key]
        public int StepStatusId { get; set; }
        public virtual ICollection<AdminWFProcess> WFProcesses { get; set; }
        #endregion
    }
}
