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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int StepId { get; set; }
        [Required]
        [ForeignKey("AdminWFMaster")]
        public int WorkFlowId { get; set; }
        [ForeignKey("AdminActor"), Column(Order = 0)]
        [Required]
        public int ActorIdTenantId { get; set; }
        [ForeignKey("AdminActor"), Column(Order = 1)]
        [Required]
        public int ActorId { get; set; }
        [ForeignKey("AdminWFStep"), Column(Order = 0)]
        public int NextStepIdTenantId { get; set; }
        [ForeignKey("AdminWFStep"), Column(Order = 1)]
        public int NextStepId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 0)]
        public int DocumentIdTenantId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 1)]
        public int DocumentIdWorkFlowId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 2)]
        public int DocumentId { get; set; }
        [Required]
        public byte IsFirstStep { get; set; }
        #endregion
    }
}
