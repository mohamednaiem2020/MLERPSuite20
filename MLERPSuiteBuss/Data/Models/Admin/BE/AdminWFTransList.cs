using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWFTransList
    {
        #region Constructor
        public AdminWFTransList()
        {
        }
        #endregion
        #region Properties
        [Required]
        public Guid HeaderGuidId { get; set; }
       
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        
        public int WorkFlowId { get; set; }
         
        public int CurrentTransId { get; set; }
        [Required]
        public int TransStatusId { get; set; }
       
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public string TransactionCode { get; set; }
        public int DocumentId { get; set; }
     
        public int ErrorId { get; set; }
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
