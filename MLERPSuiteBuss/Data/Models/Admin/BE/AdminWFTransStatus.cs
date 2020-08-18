using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWFTransStatus
    {
        #region Constructor
        public AdminWFTransStatus()
        {
        }
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransStatusId { get; set; }
        public virtual ICollection<AdminWFTransList> WFTransList { get; set; }
        #endregion
    }
}
