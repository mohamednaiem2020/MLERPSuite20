using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWFProcess
    {
        #region Constructor
        public AdminWFProcess()
        {
        }
        #endregion

        #region Properties
     
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
  
        public int StepId { get; set; }
       
        public int TransactionId { get; set; }
        [Required]
        public int StepStatusId { get; set; }
       
        [Required]
        public Guid HeaderGuidId { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
