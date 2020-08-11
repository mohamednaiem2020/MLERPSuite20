using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWfStepAction
    {
        #region Constructor
        public AdminWfStepAction()
        {
        }
        #endregion

        #region Properties
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        [Key, Column(Order = 1)]
        public int StepId { get; set; }
        public virtual AdminWFStep WFStep { get; set; }

        [Key, Column(Order = 2)]
        public int ActionId { get; set; }
        [Required]
        public string ClassName { get; set; }
        [Required]
        public string FunctionName { get; set; }
        [Required]
        public int OrderId { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsDisabled { get; set; }
        #endregion
    }
}
