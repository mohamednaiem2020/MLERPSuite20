using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminLanguage
    {
        #region Constructor
        public AdminLanguage()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int LanguageId { get; set; }
        public virtual ICollection<AdminObjectLanguage> ObjectLanguages { get; set; }
        public virtual ICollection<AdminScreenLanguage> ScreenLanguage { get; set; }
        public virtual ICollection<AdminTenantLanguage> TenantLanguages { get; set; }
        [Required]
        public string LanguageDescription { get; set; }
        [DefaultValue(0)]
        [Required]
        public int IsRightToLeft { get; set; }
      
        #endregion
    }
}
