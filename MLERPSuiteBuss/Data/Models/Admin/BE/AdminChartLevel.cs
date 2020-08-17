using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminChartLevel
    {
        #region Constructor
        public AdminChartLevel()
        {
        }
        #endregion
        #region Properties
       
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }

      
        public int ChartLevelId { get; set; }
        public virtual ICollection<AdminChart> Charts { get; set; }

        [Required]
        public byte ChartCodeLength { get; set; }
       
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
