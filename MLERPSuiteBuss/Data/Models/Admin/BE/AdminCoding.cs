﻿using System;
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
            
        public int DocumentId { get; set; }
     

        [Required]
        public int NumberLength { get; set; }
        [Required]
        public string SplitCharcter { get; set; }
        
        [Required]
        public int WithPrefix { get; set; }
        [Required]
        public string PrefixCode { get; set; }
        
        [Required]
        public int WithMonthYear { get; set; }
        
        [Required]
        public int WithLocation { get; set; }
        [Required]
        public string CurrentNumber { get; set; }

        #endregion
    }
}
