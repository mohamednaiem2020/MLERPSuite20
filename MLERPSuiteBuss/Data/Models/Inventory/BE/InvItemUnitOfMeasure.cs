﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvItemUnitOfMeasure
    {
        #region Constructor
        public InvItemUnitOfMeasure()
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
        public int UnitId { get; set; }
        [Required]
        public string UnitCode { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 0)]
        [Required]
        public int CreatedByTenantId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 1)]
        [Required]
        public int CreatedBy { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 0)]
        [Required]
        public int EditedByTenantId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 1)]
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
