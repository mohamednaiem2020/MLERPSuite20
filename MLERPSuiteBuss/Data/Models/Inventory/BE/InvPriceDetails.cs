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
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        [Key, Column(Order = 1)]
        public int PriceListId { get; set; }
        public virtual InvPriceHeader PriceHeader { get; set; }

        [Key, Column(Order = 2)]
        public int PriceListDetailsId { get; set; }

        [Key, Column(Order = 3)]
        public int ItemId { get; set; }
        [Key, Column(Order = 4)]
        public int UnitId { get; set; }
        public virtual InvItemUnit ItemUnit { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        #endregion
    }
}
