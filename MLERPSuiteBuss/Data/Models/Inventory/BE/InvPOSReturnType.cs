using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSReturnType
    {
        #region Constructor
        public InvPOSReturnType()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int InvPOSReturnTypeId { get; set; }
        public virtual ICollection<InvPOSReturnHeader> POSReturnHeaders { get; set; }
        #endregion
    }
}
