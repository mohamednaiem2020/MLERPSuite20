using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Inventory.BE;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminUser
    {
        #region Constructor
        public AdminUser()
        {
        }
        #endregion

        #region Properties
       
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
       
        public int UserId { get; set; }
        public virtual ICollection<InvPOSZread> POSZreads { get; set; }
        [Required]
        public string UserFullName { get; set; }
        [Required]
        public string LoginUserName { get; set; }
        [Required]
        public string Password { get; set; }
        
        [Required]
        public byte IsDisabled { get; set; }
        
        [Required]
        public byte IsAdmin { get; set; }
        public int ChartId { get; set; }
       
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
