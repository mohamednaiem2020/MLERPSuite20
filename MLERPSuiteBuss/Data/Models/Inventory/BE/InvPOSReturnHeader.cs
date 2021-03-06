﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSReturnHeader
    {
        #region Constructor
        public InvPOSReturnHeader()
        {
        }
        #endregion

        #region Properties
        
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        
        public int? ReturnInvoiceId { get; set; }
        public virtual ICollection<InvPOSReturnDetails> POSReturnDetails { get; set; }
        public virtual ICollection<InvPOSSalesPayment> POSSalesPayments { get; set; }
        [Required]
        public int POSReturnTypeId { get; set; }
        
        [Required]
        public int WorkFlowId { get; set; }
      
        public int DocumentId { get; set; }
        [Required]
        public int TransStatusId { get; set; }
        [Required]
        public string ReturnInvoiceCode { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ReturnInvoiceDate { get; set; }
        public int InvoiceIdRefernce { get; set; }
         
        public int TerminalId { get; set; }
        
       
        public int LocationId { get; set; }
       
     
        public int? CustId { get; set; }
        
        
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
       
        public int? NoteId { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HeaderGuidId { get; set; }
        
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public int EditedBy { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
