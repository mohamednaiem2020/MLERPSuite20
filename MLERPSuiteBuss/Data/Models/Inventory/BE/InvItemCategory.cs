using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Admin.BE;

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
        
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
       
        public int CatId { get; set; }
        public virtual ICollection<InvItemCategory> ItemCategories { get; set; }
        public virtual ICollection<InvItemMaster> ItemMasters { get; set; }
        [Required]
        public string CatCode { get; set; }
        public string CatRef { get; set; }
      
        public int? CatParentId { get; set; }
       

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
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
