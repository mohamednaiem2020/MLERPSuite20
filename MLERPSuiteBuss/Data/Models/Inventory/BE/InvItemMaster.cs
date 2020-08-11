using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvItemMaster
    {
        #region Constructor
        public InvItemMaster()
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
        public int ItemId { get; set; }
        [Required]
        public string ItemCode { get; set; }
        public string ItemRef { get; set; }
        public string ItemCode1 { get; set; }
        public string ItemCode2 { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsDisabled { get; set; }
        [Required]
        public int CatId { get; set; }
       
        public int NoteId { get; set; }
        public int BaseUnitIdCashed { get; set; }
        public int BigUnitIdCashed { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal BaseToBigFactorCashed { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal BigToBaseFactorCashed { get; set; }
 
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
