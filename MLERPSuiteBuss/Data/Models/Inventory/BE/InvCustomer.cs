using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        [Required]
        [ForeignKey("AdminTenant")]
        public int TenantId { get; set; }
        [Key]
        [Required]
        public int CustId { get; set; }
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
        public string CustAddress { get; set; }
        public int AddressProvince { get; set; }
        public int AddressTown { get; set; }
        public int AddressBlock { get; set; }
        public string AddressStreetNo { get; set; }
        public string AddressBuildingNo { get; set; }
        public string AddressFlat { get; set; }
        [ForeignKey("AdminNotes"), Column(Order = 0)]
        public int NoteIdTenantId { get; set; }
        [ForeignKey("AdminNotes"), Column(Order = 1)]
        public int NoteId { get; set; }
        [ForeignKey("AdminUser"), Column(Order = 1)]
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
