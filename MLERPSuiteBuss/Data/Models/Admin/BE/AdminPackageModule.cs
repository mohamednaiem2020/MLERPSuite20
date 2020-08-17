using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminPackageModule
    {
        #region Constructor
        public AdminPackageModule()
        {
        }
        #endregion
        #region Properties
        
        public int PackageId { get; set; }
        
        public int ModuleId { get; set; }
       


        #endregion
    }
}
