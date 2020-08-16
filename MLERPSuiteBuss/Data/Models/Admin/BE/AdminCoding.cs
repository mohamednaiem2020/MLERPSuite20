using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminCoding
    {
        #region Constructor
        public AdminCoding()
        {
        }
        #endregion

        #region Properties

      
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        [Required]
        public int WorkFlowId { get; set; }
        public virtual AdminWFMaster WFMaster { get; set; }

       
        public int DocumentId { get; set; }
        public virtual AdminWFDocument WFDocument { get; set; }

        [Required]
        public int NumberLength { get; set; }
        [Required]
        public string SplitCharcter { get; set; }
        [DefaultValue(0)]
        [Required]
        public int WithPrefix { get; set; }
        [Required]
        public string PrefixCode { get; set; }
        [DefaultValue(0)]
        [Required]
        public int WithMonthYear { get; set; }
        [DefaultValue(0)]
        [Required]
        public string WithLocation { get; set; }
        [Required]
        public string CurrentNumber { get; set; }

        #endregion
    }
}
