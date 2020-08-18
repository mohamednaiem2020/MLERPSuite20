using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSSalesPaymentMethod
    {
        #region Constructor
        public InvPOSSalesPaymentMethod()
        {
        }
        #endregion
        #region Properties
     
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
     
        public int PaymentMethodId { get; set; }
        public virtual ICollection<InvPOSSalesPayment> POSSalesPayments { get; set; }
        public virtual ICollection<InvPOSZreadDetails> POSZreadDetails { get; set; }
        [Required]
        public string PaymentMethodCode { get; set; }
        public string PaymentMethodRef { get; set; }
        
        [Required]
        public byte IsKeyNet { get; set; }
        
        [Required]
        public byte IsMasterCard { get; set; }
        
        [Required]
        public byte IsVoucher { get; set; }
        
        [Required]
        public byte IsDisabled { get; set; }
       
        public int NoteId { get; set; }
       
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
