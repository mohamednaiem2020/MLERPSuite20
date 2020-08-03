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
        [ForeignKey("AdminScreen")]
        [Required]
        public int ScreenId { get; set; }
        [Key]
        [ForeignKey("AdminLanguage")]
        [Required]
        public int LanguageId { get; set; }
        [Key]
        [Required]
        public int LabelId { get; set; }
        [Required]
        public int LabelCaption { get; set; }
        #endregion
    }
}
