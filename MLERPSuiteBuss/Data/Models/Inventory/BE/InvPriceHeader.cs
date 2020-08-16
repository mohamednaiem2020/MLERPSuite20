using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Admin.BE;


namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPriceHeader
    {
        #region Constructor
        public InvPriceHeader()
        {
        }
        #endregion
        #region Properties
       
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

      
        public int PriceListId { get; set; }
        public virtual ICollection<InvLocation> Locations { get; set; }
        public virtual ICollection<InvPriceDetails> PriceDetails { get; set; }

        [Required]
        public string PriceListCode { get; set; }
        public string PriceListRef { get; set; }
       
        public int NoteId { get; set; }
      
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
