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
      
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
     
        public int InvoiceId { get; set; }
        
        public int PaymentMethodId { get; set; }
       
        public int ReturnVoucherRetId { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal PaymentAmount { get; set; }
        #endregion

    }
}
