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
        [Key, Column(Order = 0)]
        public int ModuleId { get; set; }
        public virtual AdminModule Module { get; set; }

        [Key, Column(Order = 1)]
        public int ScreenId { get; set; }
        public virtual AdminScreen Screen { get; set; }
        #endregion
    }
}
