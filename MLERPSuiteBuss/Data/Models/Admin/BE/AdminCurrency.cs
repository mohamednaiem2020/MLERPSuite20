using System;
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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int CurrencyId { get; set; }
        [Required]
        public string CurrencyCode { get; set; }
        [Required]
        public byte DigitCount { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsLocalCurrency { get; set; }
        [Required]
        public int CreatedByTenantId { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public int EditedByTenantId { get; set; }
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
