using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminScreenLanguage
    {
        #region Constructor
        public AdminScreenLanguage()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int ScreenId { get; set; }
        public virtual AdminScreen Screen { get; set; }
        [Key]
        public int LanguageId { get; set; }
        public virtual AdminLanguage Language { get; set; }
        [Key]
        public string LabelId { get; set; }
        [Required]
        public string Caption { get; set; }
        #endregion
    }
}
