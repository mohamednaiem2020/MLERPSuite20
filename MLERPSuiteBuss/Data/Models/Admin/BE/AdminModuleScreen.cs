using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminModuleScreen
    {
        #region Constructor
        public AdminModuleScreen()
        {
        }
        #endregion
        #region Properties
        public int ModuleId { get; set; }
  
      
        public int ScreenId { get; set; }
     
        #endregion
    }
}
