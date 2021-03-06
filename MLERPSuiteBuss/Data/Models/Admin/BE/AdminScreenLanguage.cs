﻿using System;
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
       
        public int ScreenId { get; set; }
       
        public int LanguageId { get; set; }
        [Required]
        public string LabelId { get; set; }
        [Required]
        public string Caption { get; set; }
        #endregion
    }
}
