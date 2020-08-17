using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MLERPSuiteBuss.Data.Models.Admin.BE;

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
      
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
     
        public int ZreadId { get; set; }
        public virtual ICollection<InvPOSZreadDetails> POSZreadDetails { get; set; }
        [Required]
        public int WorkFlowId { get; set; }
     
        public int DocumentId { get; set; }
        
        [Required]
        public string ZreadCode { get; set; }
        [Required]
        public DateTime ZreadDate { get; set; }
        public int TerminalId { get; set; }
      
        public int LocationId { get; set; }
      
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
       
        public int NoteId { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
