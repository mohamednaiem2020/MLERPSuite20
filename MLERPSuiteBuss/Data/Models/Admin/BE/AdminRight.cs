using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminRight
    {
        #region Constructor
        public AdminRight()
        {
        }
        #endregion

        #region Properties
        [Key]
        [Required]
        public int RightId { get; set; }
        #endregion
    }
}
