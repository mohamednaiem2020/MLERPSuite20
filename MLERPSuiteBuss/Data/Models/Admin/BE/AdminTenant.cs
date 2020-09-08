using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MLERPSuiteBuss.Data.Models.Inventory.BE;

namespace MLERPSuiteBuss.Data.Models.Admin.BE
{
    public class AdminTenant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TenantId { get; set; }
        [Required]
        public string TenantDescription { get; set; }

        #region Admin
        public virtual ICollection<AdminActor> Actors { get; set; }
        public virtual ICollection<AdminChart> Charts { get; set; }
        public virtual ICollection<AdminChartLevel> ChartLevels { get; set; }
        public virtual ICollection<AdminCoding> Codings { get; set; }
        public virtual ICollection<AdminCurrency> Currencies { get; set; }
        public virtual ICollection<AdminNationality> Nationalities { get; set; }
        public virtual ICollection<AdminNotes> Notes { get; set; }
        public virtual ICollection<AdminObjectLanguage> ObjectLanguages { get; set; }
        public virtual ICollection<AdminTenantLanguage> TenantLanguages { get; set; }
        public virtual ICollection<AdminTenantPackage> TenantPackages { get; set; }
        public virtual ICollection<AdminUser> Users { get; set; }
        public virtual ICollection<AdminWFDocument> WFDocuments { get; set; }
        public virtual ICollection<AdminWFProcess> WFProcesses { get; set; }
        public virtual ICollection<AdminWFStep> WFSteps { get; set; }
        public virtual ICollection<AdminWfStepAction> WFStepAction { get; set; }
        public virtual ICollection<AdminWFTransList> WFTRansList { get; set; }
        #endregion

        #region Inventory and POS
        public virtual ICollection<InvCustomer> Customers { get; set; }
        public virtual ICollection<InvItemCategory> ItemCategories { get; set; }
        public virtual ICollection<InvItemCategoryLevel> ItemCategoryLevels { get; set; }
        public virtual ICollection<InvItemMaster> ItemMasters { get; set; }
        public virtual ICollection<InvItemUnit> ItemUnits { get; set; }
        public virtual ICollection<InvItemUnitBarcode> ItemUnitBarcodes { get; set; }
        public virtual ICollection<InvItemUnitMatrix> ItemUnitMaxtrixes { get; set; }
        public virtual ICollection<InvItemUnitOfMeasurement> ItemUnitOfMeasures { get; set; }
        public virtual ICollection<InvLocation> Locations { get; set; }
        public virtual ICollection<InvLocationLevel> LocationLevels { get; set; }
        public virtual ICollection<InvPriceHeader> PriceHeaders { get; set; }
        public virtual ICollection<InvPriceDetails> PriceDetails { get; set; }
        public virtual ICollection<InvPOSTerminal> POSTerminals { get; set; }
        public virtual ICollection<InvPOSSalesHeader> POSSalesHeaders { get; set; }
        public virtual ICollection<InvPOSReturnHeader> POSReturnHeaders { get; set; }
        public virtual ICollection<InvPOSSalesPaymentMethod> POSSalesPaymentMethods { get; set; }
        public virtual ICollection<InvPOSSalesDetails> POSSalesDetails { get; set; }
        public virtual ICollection<InvPOSReturnDetails> POSReturnDetails { get; set; }
        public virtual ICollection<InvPOSSalesPayment> POSSalesPayments { get; set; }
        public virtual ICollection<InvPOSZread> POSZreads { get; set; }
        public virtual ICollection<InvPOSZreadDetails> POSZreadDetails { get; set; }
        #endregion
    }
}
