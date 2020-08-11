using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{

    public class InvItemCategory
    {
        #region Constructor
        public InvItemCategory()
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
        public int CatId { get; set; }
        [Required]
        public string CatCode { get; set; }
        public string CatRef { get; set; }
        [ForeignKey("InvItemCategory"), Column(Order = 0)]
        public int CatParentIdTenantId { get; set; }
        [ForeignKey("InvItemCategory"), Column(Order = 1)]
        public int CatParentId { get; set; }
        [ForeignKey("InvItemCategoryLevel"), Column(Order = 0)]
        [Required]
        public int CatLevelIdTenantId { get; set; }
        [ForeignKey("InvItemCategoryLevel"), Column(Order = 1)]
        [Required]
        public int CatLevelId { get; set; }
        [Required]
        public int CatLevelId1 { get; set; }
        public int CatLevelId2 { get; set; }
        public int CatLevelId3 { get; set; }
        public int CatLevelId4 { get; set; }
        public int CatLevelId5 { get; set; }
        public int CatLevelId6 { get; set; }
        public byte CatIsLeaf { get; set; }
       
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
