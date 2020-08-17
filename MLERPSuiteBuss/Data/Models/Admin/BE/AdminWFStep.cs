using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWFStep
    {
        #region Constructor
        public AdminWFStep()
        {
        }
        #endregion
        #region Properties
        
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
 
        public int StepId { get; set; }
        public virtual ICollection<AdminWFProcess> WFProcesses { get; set; }
        public virtual ICollection<AdminWFStep> WFSteps { get; set; }
        public virtual ICollection<AdminWfStepAction> WFStepAction { get; set; }

        [Required]
        public int WorkFlowId { get; set; }
       
        public int ActorId { get; set; }
      
        public int NextStepId { get; set; }
     
        public int DocumentId { get; set; }
     
        [DefaultValue(0)]
        [Required]
        public byte IsFirstStep { get; set; }
 
        #endregion
    }
}
