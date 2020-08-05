using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSZread
    {
        #region Constructor
        public InvPOSZread()
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
        public int ZreadId { get; set; }
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
        public string ZreadCode { get; set; }
        [Required]
        public DateTime ZreadDate { get; set; }
        [ForeignKey("InvPOSTerminal"), Column(Order = 0)]
        [Required]
        public int TerminalIdTenantId { get; set; }
        [ForeignKey("InvPOSTerminal"), Column(Order = 1)]
        [Required]
        public int TerminalId { get; set; }
        [ForeignKey("InvLocation"), Column(Order = 0)]
        [Required]
        public int LocationIdTenantId { get; set; }
        [ForeignKey("InvLocation"), Column(Order = 1)]
        [Required]
        public int LocationId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 0)]
        [Required]
        public int UserIdTenantId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 1)]
        [Required]
        public int UserId { get; set; }
        [Required]
        public int InvoiceIdFrom { get; set; }
        [Required]
        public int InvoiceIdTo { get; set; }
        [Required]
        public int ReturnInvoiceIdFrom { get; set; }
        [Required]
        public int ReturnInvoiceIdTo { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal ReturnNetAmount { get; set; }
        public int NoteIdTenantId { get; set; }
        public int NoteId { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HeaderGuidId { get; set; }
        [Required]
        public int CreatedByTenantId { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public int EditedByTenantId { get; set; }
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
