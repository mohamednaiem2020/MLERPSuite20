using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWFTransList
    {
        #region Constructor
        public AdminWFTransList()
        {
        }
        #endregion

        #region Properties
        [Required]
        public Guid HeaderGuidId { get; set; }
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        [ForeignKey("AdminWFMaster")]
        public int WorkFlowId { get; set; }
        [Key]
        [Required]
        public int CurrentTransId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 0)]
        [Required]
        public int DocumentIdTenantId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 1)]
        [Required]
        public int DocumentIdWorkFlowId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 2)]
        [Required]
        public int DocumentId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public string TransactionCode { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte TransStatus { get; set; }
        public int ErrorId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 0)]
        [Required]
        public int CreatedByTenantId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 1)]
        [Required]
        public int CreatedBy { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 0)]
        [Required]
        public int EditedByTenantId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 1)]
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }

        #endregion
    }
}
