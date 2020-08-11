using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminScreenLevel
    {
        #region Constructor
        public AdminScreenLevel()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int ScreenLevelId { get; set; }
        public virtual ICollection<AdminScreen> Screens { get; set; }
        #endregion
    }
}
