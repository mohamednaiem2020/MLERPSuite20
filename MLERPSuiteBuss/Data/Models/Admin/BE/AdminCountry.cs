using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminCountry
    {
        #region Constructor
        public AdminCountry()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int CountryId { get; set; }
        public virtual ICollection<AdminProvince> Provinces { get; set; }
        #endregion
    }
}
