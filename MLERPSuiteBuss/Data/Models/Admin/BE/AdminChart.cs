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
       
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

        
     
        public int ChartId { get; set; }
        public virtual ICollection<AdminChart> Charts { get; set; }
        public virtual ICollection<AdminUser> Users { get; set; }

        [Required]
        public string ChartCode { get; set; }
        public string ChartRef { get; set; }
       
        public int ChartParentId { get; set; }
        public virtual AdminChart Chart { get; set; }

        
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

        
       
        public int NoteId { get; set; }
       
        [Required]
        public int CreatedBy { get; set; }
        
        [Required]
        public int EditedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime EditedDate { get; set; }
        #endregion
    }
}
 