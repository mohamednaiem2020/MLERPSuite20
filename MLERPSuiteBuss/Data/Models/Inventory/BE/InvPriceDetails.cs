using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPriceDetails
    {
        #region Constructor
        public InvPriceDetails()
        {
        }
        #endregion
        #region Properties
      
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
      
        public int PriceListId { get; set; }
          
       
        public int ItemId { get; set; }
      
        public int UnitId { get; set; }
        

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        #endregion
    }
}
