using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvPOSSalesType
    {
        #region Constructor
        public InvPOSSalesType()
        {
        }
        #endregion
        #region Properties
        [Key]
        public int InvPOSSalesTypeId { get; set; }
        public virtual ICollection<InvPOSSalesHeader> POSSalesHeaders { get; set; }
        #endregion
    }
}
