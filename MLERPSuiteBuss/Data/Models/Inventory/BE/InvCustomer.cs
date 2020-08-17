using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Admin.BE;

namespace MLERPSuiteBuss.Data.Models.Inventory.BE
{
    public class InvCustomer
    {
        #region Constructor
        public InvCustomer()
        {
        }
        #endregion

        #region Properties
      
        public int TenantId { get; set; }
        public virtual AdminTenant Tenant { get; set; }
      
        public int CustId { get; set; }
        public virtual ICollection<InvPOSSalesHeader> POSSalesHeaders { get; set; }
        public virtual ICollection<InvPOSReturnHeader> POSReturnHeaders { get; set; }
        [Required]
        public string CustCode { get; set; }
        public string CustRef { get; set; }
        [DefaultValue(0)]
        [Required]
        public byte IsDisabled { get; set; }
        public string CustTelNo { get; set; }
        public string CustMobileNo { get; set; }
        public string CustFaxNo { get; set; }
        public string CustEmail1 { get; set; }
        public string CustWebsite { get; set; }
        public string CustContactPerson { get; set; }
        public string CustFullAddress { get; set; }

        public int ProvinceId { get; set; }
     
        public int TownId { get; set; }
        
        public int BlockNo { get; set; }
        public string StreetNo { get; set; }
        public string BuildingNo { get; set; }
        public string FlatNo { get; set; }
       
        public int NoteId { get; set; }
        
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
