using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int PriceListId { get; set; }
        [Required]
        public string PriceListCode { get; set; }
        public string PriceListRef { get; set; }
        [ForeignKey("AdminNotes"), Column(Order = 0)]
        public int NoteIdTenantId { get; set; }
        [ForeignKey("AdminNotes"), Column(Order =1)]
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
