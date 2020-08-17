using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Inventory.BE;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminTown
    {
        #region Constructor
        public AdminTown()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int TownId { get; set; }
        public virtual ICollection<InvCustomer> Customers { get; set; }
        public int ProvinceId { get; set; }
      

        #endregion
    }
}
