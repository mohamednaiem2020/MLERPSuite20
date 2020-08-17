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
    public class InvPOSSalesDetails
    {
        #region Constructor
        public InvPOSSalesDetails()
        {
        }
        #endregion
        #region Properties
      
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
      
        public int InvoiceId { get; set; }
       
       
        public int DetailsId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
      
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal NetAmount { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DetailsGuidId { get; set; }
        #endregion
    }
}
