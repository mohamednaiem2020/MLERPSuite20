using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvLocation
    {
        #region Constructor
        public InvLocation()
        {
        }
        #endregion
        #region Properties
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        [Key, Column(Order = 1)]
        public int LocationId { get; set; }
        public virtual ICollection<InvLocation> Locations { get; set; }
        public virtual ICollection<InvPOSTerminal> POSTerminals { get; set; }
        public virtual ICollection<InvPOSSalesHeader> POSSalesHeaders { get; set; }
        public virtual ICollection<InvPOSReturnHeader> POSReturnHeaders { get; set; }
        public virtual ICollection<InvPOSZread> POSZreads { get; set; }
        [Required]
        public string LocationCode { get; set; }
        public string LocationRef { get; set; }
        
        public int LocationParentId { get; set; }
        public virtual InvLocation Location { get; set; }

        public int LocationLevelId { get; set; }
        public virtual InvLocationLevel LocationLevel { get; set; }

        [Required]
        public int LocationLevelId1 { get; set; }
        public int LocationLevelId2 { get; set; }
        public int LocationLevelId3 { get; set; }
        public int LocationLevelId4 { get; set; }
        public int LocationLevelId5 { get; set; }
        public int LocationLevelId6 { get; set; }

        [DefaultValue(0)]
        [Required]
        public byte LocationIsLeaf { get; set; }

        public int PriceListId { get; set; }
        public virtual InvPriceHeader PriceHeader { get; set; }

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
