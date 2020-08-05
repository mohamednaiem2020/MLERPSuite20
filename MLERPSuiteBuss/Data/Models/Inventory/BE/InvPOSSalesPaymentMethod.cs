using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int PaymentMethodId { get; set; }
        [Required]
        public string PaymentMethodCode { get; set; }
        public string PaymentMethodRef { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsKeyNet { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsMasterCard { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsVoucher { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsDisabled { get; set; }
        public int NoteIdTenantId { get; set; }
        public int NoteId { get; set; }
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
