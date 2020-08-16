using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminActor
    { 
        #region Constructor
        public AdminActor()
        {
        }
        #endregion

        #region Properties
      
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

       
        public int ActorId { get; set; }
        public virtual ICollection<AdminWFStep> WFSteps { get; set; }

        #endregion
    }
}
