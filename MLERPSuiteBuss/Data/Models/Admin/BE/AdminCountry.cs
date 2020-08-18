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
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        public int CountryId { get; set; }
        public virtual ICollection<AdminProvince> Provinces { get; set; }
        #endregion
    }
}
