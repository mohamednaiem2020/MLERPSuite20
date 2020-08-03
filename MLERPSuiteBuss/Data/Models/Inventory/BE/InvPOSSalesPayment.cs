using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSSalesPayment
    {
        #region Constructor
        public InvPOSSalesPayment()
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
        [Key]
        [Required]
        public int PaymentMethodId { get; set; }
        [ForeignKey("InvPOSReturnHeader"), Column(Order = 0)]
        public int ReturnVoucherRetIdTenantId { get; set; }
        [ForeignKey("InvPOSReturnHeader"), Column(Order = 1)]
        public int ReturnVoucherRetId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal PaymentAmount { get; set; }
        #endregion

    }
}
