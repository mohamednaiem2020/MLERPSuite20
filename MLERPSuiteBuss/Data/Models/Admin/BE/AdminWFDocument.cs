using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Inventory.BE;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminWFDocument
    {
        #region Constructor
        public AdminWFDocument()
        {
        }
        #endregion

        #region Properties
        [Key, Column(Order = 0)]
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
        [Key, Column(Order = 1)]
        public int WorkFlowId { get; set; }
        public virtual AdminWFMaster WFMaster { get; set; }
        [Key, Column(Order = 2)]
        public int DocumentId { get; set; }
        public virtual ICollection<AdminCoding> Codings { get; set; }
        public virtual ICollection<AdminWFStep> WFSteps { get; set; }
        public virtual ICollection<AdminWFTransList> WFTransList { get; set; }
        public virtual ICollection<InvPOSSalesHeader> POSSalesHeaders { get; set; }
        public virtual ICollection<InvPOSReturnHeader> POSReturnHeaders { get; set; }
        public virtual ICollection<InvPOSZread> POSZreads { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsDisabled { get; set; }
        #endregion
    }
}
