﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminCurrency
    {
        #region Constructor
        public AdminCurrency()
        {
        }
        #endregion

        #region Properties
   
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
     
        public int CurrencyId { get; set; }
        [Required]
        public string CurrencyCode { get; set; }
        [Required]
        public byte DigitCount { get; set; }
        
        [Required]
        public byte IsLocalCurrency { get; set; }
        
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public int EditedBy { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
