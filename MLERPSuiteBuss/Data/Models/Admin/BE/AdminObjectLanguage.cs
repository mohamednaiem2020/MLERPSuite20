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
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        [Key]
        public int LanguageId { get; set; }
        public virtual AdminLanguage Language { get; set; }
        [Key]
        public int ObjectId { get; set; }
        public virtual AdminObject Object { get; set; }
        [Key]
        public int RowId { get; set; }
        [Required]
        public int RowDescription { get; set; }
        #endregion
    }
}
