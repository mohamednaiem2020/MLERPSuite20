using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MLERPSuiteBuss.Data.Models.Admin.BE;

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
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        [Key, Column(Order = 1)]
        public int InvoiceId { get; set; }
        public virtual InvPOSSalesHeader POSSalesHeader { get; set; }
        [Key, Column(Order = 2)]
        public int PaymentMethodId { get; set; }
        public virtual InvPOSSalesPaymentMethod POSSalesPaymentMethod { get; set; }
        public int ReturnVoucherRetId { get; set; }
        public virtual InvPOSReturnHeader POSReturnHeader { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal PaymentAmount { get; set; }
        #endregion

    }
}
