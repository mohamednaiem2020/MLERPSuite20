using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSTerminal
    {
        #region Constructor
        public InvPOSTerminal()
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
        public int TerminalId { get; set; }
        [Required]
        public string TerminalCode { get; set; }
     
        public string TerminalRef { get; set; }
        [ForeignKey("InvLocation")]
        [Required]
        public int LocationId { get; set; }
       
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
