﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Inventory.BE;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminProvince
    {
        #region Constructor
        public AdminProvince()
        {
        }
        #endregion
        #region Properties
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        public int ProvinceId { get; set; }
        public virtual ICollection<AdminTown> Towns { get; set; }
        public virtual ICollection<InvCustomer> Customers { get; set; }
        public int CountryId { get; set; }
        
        #endregion
    }
}
