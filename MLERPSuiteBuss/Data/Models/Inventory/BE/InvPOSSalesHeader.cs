using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSSalesHeader
    {
        #region Constructor
        public InvPOSSalesHeader()
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
        public int InvoiceId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 0)]
        [Required]
        public int DocumentIdTenantId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 1)]
        [Required]
        public int DocumentIdWorkFlowId { get; set; }
        [ForeignKey("AdminWFDocument"), Column(Order = 2)]
        [Required]
        public int DocumentId { get; set; }
        [ForeignKey("InvPOSSalesType")]
        [Required]
        public int InvPOSSalesTypeId { get; set; }
        [Required]
        public string InvoiceCode { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }
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
        [ForeignKey("InvCustomer"), Column(Order = 0)]
        public int CustIdTenantId { get; set; }
        [ForeignKey("InvCustomer"), Column(Order = 1)]
        public int CustId { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
        [DefaultValue(0)]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
        [ForeignKey("AdminNotes"), Column(Order = 0)]
        public int NoteIdTenantId { get; set; }
        [ForeignKey("AdminNotes"), Column(Order = 1)]
        public int NoteId { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HeaderGuidId { get; set; }
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
