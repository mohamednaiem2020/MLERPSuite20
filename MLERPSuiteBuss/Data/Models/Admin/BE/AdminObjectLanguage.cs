using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminObjectLanguage
    {
        #region Constructor
        public AdminObjectLanguage()
        {
        }
        #endregion
        #region Properties
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [ForeignKey("AdminLanguage")]
        [Required]
        public int LanguageId { get; set; }
        [Key]
        [ForeignKey("AdminObject")]
        [Required]
        public int ObjectId { get; set; }
        [Key]
        [Required]
        public int RowId { get; set; }
        [Required]
        public int RowDescription { get; set; }
        #endregion
    }
}
