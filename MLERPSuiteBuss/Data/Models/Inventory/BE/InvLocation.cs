﻿using System;
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
       
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        
        public int LocationId { get; set; }
        public virtual ICollection<InvLocation> Locations { get; set; }
        public virtual ICollection<InvPOSTerminal> POSTerminals { get; set; }
        public virtual ICollection<InvPOSSalesHeader> POSSalesHeaders { get; set; }
        public virtual ICollection<InvPOSReturnHeader> POSReturnHeaders { get; set; }
        public virtual ICollection<InvPOSZread> POSZreads { get; set; }
        [Required]
        public string LocationCode { get; set; }
        public string LocationRef { get; set; }
        
        public int? LocationParentId { get; set; }
        
        public int LocationLevelId { get; set; }
        
        [Required]
        public int LocationLevelId1 { get; set; }
        public int LocationLevelId2 { get; set; }
        public int LocationLevelId3 { get; set; }
        public int LocationLevelId4 { get; set; }
        public int LocationLevelId5 { get; set; }
        public int LocationLevelId6 { get; set; }

        
        [Required]
        public byte LocationIsLeaf { get; set; }

        public int? PriceListId { get; set; }
        
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
