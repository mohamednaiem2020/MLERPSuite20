using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string LocationCode { get; set; }
        public string LocationRef { get; set; }
        [ForeignKey("InvLocation"), Column(Order = 0)]
        public int LocationParentIdTenantId { get; set; }
        [ForeignKey("InvLocation"), Column(Order = 1)]
        public int LocationParentId { get; set; }
        [ForeignKey("InvLocationLevel"), Column(Order = 0)]
        [Required]
        public int CatLevelIdTenantId { get; set; }
        [ForeignKey("InvLocationLevel"), Column(Order = 1)]
        [Required]
        public int LocationLevelId { get; set; }
        [Required]
        public int LocationLevelId1 { get; set; }
        public int LocationLevelId2 { get; set; }
        public int LocationLevelId3 { get; set; }
        public int LocationLevelId4 { get; set; }
        public int LocationLevelId5 { get; set; }
        public int LocationLevelId6 { get; set; }
        public int LocationIsLeaf { get; set; }
        [ForeignKey("InvPriceHeader"), Column(Order = 0)]
        [Required]
        public int PriceListIdTenantId { get; set; }
        [ForeignKey("InvPriceHeader"), Column(Order = 1)]
        [Required]
        public int PriceListId { get; set; }
        [ForeignKey("AdminNotes"), Column(Order = 0)]
        public int NoteIdTenantId { get; set; }
        [ForeignKey("AdminNotes"), Column(Order = 1)]
        public int NoteId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 0)]
        [Required]
        public int CreatedByTenantId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 1)]
        [Required]
        public int CreatedBy { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 0)]
        [Required]
        public int EditedByTenantId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 1)]
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
