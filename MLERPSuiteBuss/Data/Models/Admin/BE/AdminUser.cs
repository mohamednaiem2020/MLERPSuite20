using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int UserId { get; set; }
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
        [ForeignKey("AdminChart"), Column(Order = 0)]
        [Required]
        public int ChartIdTenantId { get; set; }
        [ForeignKey("AdminChart"), Column(Order = 1)]
        [Required]
        public int ChartId { get; set; }
        public int NoteIdTenantId { get; set; }
        public int NoteId { get; set; }
        [Required]
        public int CreatedByTenantId { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public int EditedByTenantId { get; set; }
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
