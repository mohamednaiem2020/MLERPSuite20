using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminChart
    {
        #region Constructor
        public AdminChart()
        {
        }
        #endregion
        #region Properties
        [Key, Column(Order = 0)]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public int ChartId { get; set; }
        public virtual ICollection<AdminChart> Charts { get; set; }

        [Required]
        public string ChartCode { get; set; }
        public string ChartRef { get; set; }

        [ForeignKey("AdminChart"), Column(Order = 0)]
        public int ChartParentIdTenantId { get; set; }
        [ForeignKey("AdminChart"), Column(Order = 1)]
        public int ChartParentId { get; set; }
        public virtual AdminChart Chart { get; set; }

        [ForeignKey("AdminChartLevel"), Column(Order = 0)]
        [Required]
        public int ChartLevelIdTenantId { get; set; }
        [ForeignKey("AdminChartLevel"), Column(Order = 1)]
        [Required]
        public int ChartLevelId { get; set; }
        public virtual AdminChartLevel ChartLevel { get; set; }

        [Required]
        public int ChartLevelId1 { get; set; }
        public int ChartLevelId2 { get; set; }
        public int ChartLevelId3 { get; set; }
        public int ChartLevelId4 { get; set; }
        public int ChartLevelId5 { get; set; }
        public int ChartLevelId6 { get; set; }
        public int ChartIsLeaf { get; set; }

        
        public int NoteIdTenantId { get; set; }
        public int NoteId { get; set; }
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
 