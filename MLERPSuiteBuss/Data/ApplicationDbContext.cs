using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MLERPSuiteBuss.Data.Models;
using MLERPSuiteBuss.Data.Models.Admin.BE;
using MLERPSuiteBuss.Data.Models.Inventory.BE;

namespace MLERPSuiteBuss.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor
        public ApplicationDbContext() : base()
        {
        }
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }
        #endregion Constructor
        #region Methods
        protected override void OnModelCreating(ModelBuilder
        modelBuilder)
        {
            modelBuilder.Entity<AdminActor>()
             .HasKey(p => new { p.TenantId, p.ActorId });

            modelBuilder.Entity<AdminChart>()
           .HasKey(p => new { p.TenantId, p.ChartId });

            modelBuilder.Entity<AdminChartLevel>()
           .HasKey(p => new { p.TenantId, p.ChartLevelId });

            modelBuilder.Entity<AdminCoding>()
           .HasKey(p => new { p.TenantId, p.DocumentId });


            modelBuilder.Entity<AdminCurrency>()
            .HasKey(p => new { p.TenantId, p.CurrencyId });

            modelBuilder.Entity<AdminModuleScreen>()
                     .HasKey(p => new { p.ModuleId, p.ScreenId });


            modelBuilder.Entity<AdminNationality>()
                  .HasKey(p => new { p.TenantId, p.NationalityId });

            modelBuilder.Entity<AdminNotes>()
                  .HasKey(p => new { p.TenantId, p.NoteId });


            modelBuilder.Entity<AdminObjectLanguage>()
                  .HasKey(p => new { p.TenantId, p.LanguageId, p.ObjectId, p.RowId });


            modelBuilder.Entity<AdminPackageModule>()
             .HasKey(p => new { p.PackageId, p.ModuleId });


            modelBuilder.Entity<AdminScreenLanguage>()
             .HasKey(p => new { p.ScreenId, p.LanguageId, p.LabelId });

            modelBuilder.Entity<AdminTenantPackage>()
             .HasKey(p => new { p.TenantId, p.PackageId });

            modelBuilder.Entity<AdminUser>()
         .HasKey(p => new { p.TenantId, p.UserId });

            modelBuilder.Entity<AdminWFDocument>()
         .HasKey(p => new { p.TenantId, p.WorkFlowId, p.DocumentId });

            modelBuilder.Entity<AdminWFProcess>()
    .HasKey(p => new { p.TenantId, p.StepId, p.TransactionId });

            modelBuilder.Entity<AdminWFStep>()
    .HasKey(p => new { p.TenantId, p.StepId });


            modelBuilder.Entity<AdminWfStepAction>()
         .HasKey(p => new { p.TenantId, p.StepId, p.ActionId });

            modelBuilder.Entity<AdminWFTransList>()
         .HasKey(p => new { p.TenantId, p.WorkFlowId, p.CurrentTransId });


            modelBuilder.Entity<InvCustomer>()
  .HasKey(p => new { p.TenantId, p.CustId });


            modelBuilder.Entity<InvItemCategory>()
.HasKey(p => new { p.TenantId, p.CatId });

            modelBuilder.Entity<InvItemCategoryLevel>()
.HasKey(p => new { p.TenantId, p.CatLevelId });

            modelBuilder.Entity<InvItemMaster>()
.HasKey(p => new { p.TenantId, p.ItemId });

            modelBuilder.Entity<InvItemUnit>()
.HasKey(p => new { p.TenantId, p.ItemId, p.UnitId });

            modelBuilder.Entity<InvItemUnitBarcode>()
.HasKey(p => new { p.TenantId, p.Barcode });


            modelBuilder.Entity<InvItemUnitMatrix>()
.HasKey(p => new { p.TenantId, p.ItemId, p.UnitIdFrom, p.UnitIdTo });


            modelBuilder.Entity<InvItemUnitOfMeasure>()
.HasKey(p => new { p.TenantId, p.UnitId });

            modelBuilder.Entity<InvLocation>()
.HasKey(p => new { p.TenantId, p.LocationId });

            modelBuilder.Entity<InvLocationLevel>()
.HasKey(p => new { p.TenantId, p.LocationLevelId });

            modelBuilder.Entity<InvPriceHeader>()
.HasKey(p => new { p.TenantId, p.PriceListId });

            modelBuilder.Entity<InvPriceDetails>()
.HasKey(p => new { p.TenantId, p.PriceListId, p.ItemId, p.UnitId });


            modelBuilder.Entity<InvPOSSalesPaymentMethod>()
.HasKey(p => new { p.TenantId, p.PaymentMethodId });

            modelBuilder.Entity<InvPOSTerminal>()
.HasKey(p => new { p.TenantId, p.TerminalId });


            modelBuilder.Entity<InvPOSSalesHeader>()
.HasKey(p => new { p.TenantId, p.InvoiceId });

            modelBuilder.Entity<InvPOSReturnHeader>()
.HasKey(p => new { p.TenantId, p.ReturnInvoiceId });


            modelBuilder.Entity<InvPOSZread>()
.HasKey(p => new { p.TenantId, p.ZreadId });


            modelBuilder.Entity<InvPOSSalesDetails>()
.HasKey(p => new { p.TenantId, p.InvoiceId, p.DetailsId });


            modelBuilder.Entity<InvPOSReturnDetails>()
.HasKey(p => new { p.TenantId, p.ReturnInvoiceId, p.DetailsId });


            modelBuilder.Entity<InvPOSSalesPayment>()
.HasKey(p => new { p.TenantId, p.InvoiceId, p.PaymentMethodId });

            modelBuilder.Entity<InvPOSZreadDetails>()
.HasKey(p => new { p.TenantId, p.ZreadId, p.PaymentMethodId });


            base.OnModelCreating(modelBuilder);

            #region Admin
            //AdminChart
            modelBuilder.Entity<AdminChartLevel>()
            .HasMany(pr => pr.Charts)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ChartLevelId });

            modelBuilder.Entity<AdminChart>()
            .HasMany(pr => pr.Charts)
            .WithOne()
            .HasForeignKey(pp => new { pp.TenantId, pp.ChartParentId });

            //AdminCoding
            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.Codings)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId });

            //AdminUser
            modelBuilder.Entity<AdminChart>()
            .HasMany(pr => pr.Users)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ChartId });

            //AdminWFProcess
            modelBuilder.Entity<AdminWFStep>()
            .HasMany(pr => pr.WFProcesses)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.StepId });

            //AdminWFStep
            modelBuilder.Entity<AdminActor>()
            .HasMany(pr => pr.WFSteps)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ActorId });

            modelBuilder.Entity<AdminWFStep>()
              .HasMany(pr => pr.WFSteps)
              .WithOne()
              .HasForeignKey(pp => new { pp.TenantId, pp.NextStepId });

            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.WFSteps)
            .WithOne()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId });

            //AdminWfStepAction
            modelBuilder.Entity<AdminWFStep>()
              .HasMany(pr => pr.WFStepAction)
              .WithOne()
              .IsRequired()
              .HasForeignKey(pp => new { pp.TenantId, pp.StepId });

            //AdminWFTransList
            modelBuilder.Entity<AdminWFDocument>()
              .HasMany(pr => pr.WFTransList)
              .WithOne()
              .IsRequired()
              .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId });
            #endregion

            #region Inventory
            //InvItemCategory
            modelBuilder.Entity<InvItemCategory>()
              .HasMany(pr => pr.ItemCategories)
              .WithOne()
              .HasForeignKey(pp => new { pp.TenantId, pp.CatParentId });

            modelBuilder.Entity<InvItemCategoryLevel>()
            .HasMany(pr => pr.ItemCategories)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.CatLevelId });

            //InvItemMaster           
            modelBuilder.Entity<InvItemCategory>()
            .HasMany(pr => pr.ItemMasters)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.CatId });

            //InvItemUnits         
            modelBuilder.Entity<InvItemMaster>()
            .HasMany(pr => pr.ItemUnits)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ItemId });

            modelBuilder.Entity<InvItemUnitOfMeasure>()
          .HasMany(pr => pr.ItemUnits)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.TenantId, pp.UnitId });


            //InvItemUnitBarcodes       
            modelBuilder.Entity<InvItemUnit>()
            .HasMany(pr => pr.ItemUnitBarcodes)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitId });


            //InvItemUnitMatrix      
            modelBuilder.Entity<InvItemUnit>()
            .HasMany(pr => pr.ItemUnitMatrixesFrom)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitIdFrom });


            modelBuilder.Entity<InvItemUnit>()
            .HasMany(pr => pr.ItemUnitMatrixesTo)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitIdTo });


            //InvLocation      
            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.Locations)
            .WithOne()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationParentId });


            modelBuilder.Entity<InvLocationLevel>()
           .HasMany(pr => pr.Locations)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.LocationLevelId });

            modelBuilder.Entity<InvPriceHeader>()
             .HasMany(pr => pr.Locations)
             .WithOne()
             .HasForeignKey(pp => new { pp.TenantId, pp.PriceListId });


            //InvPriceDetails      
            modelBuilder.Entity<InvPriceHeader>()
            .HasMany(pr => pr.PriceDetails)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.PriceListId });

            modelBuilder.Entity<InvItemUnit>()
              .HasMany(pr => pr.PriceDetails)
              .WithOne()
              .IsRequired()
              .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitId });


            //InvPOSTerminal      
            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.POSTerminals)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationId });

            //InvPOSSalesHeader      
            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.POSSalesHeaders)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId });

            modelBuilder.Entity<InvPOSTerminal>()
           .HasMany(pr => pr.POSSalesHeaders)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.TerminalId });

            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.POSSalesHeaders)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationId });


            modelBuilder.Entity<InvCustomer>()
             .HasMany(pr => pr.POSSalesHeaders)
             .WithOne()
             .HasForeignKey(pp => new { pp.TenantId, pp.CustId });



            //InvPOSReturnHeader    
            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.POSReturnHeaders)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId });

            modelBuilder.Entity<InvPOSTerminal>()
           .HasMany(pr => pr.POSReturnHeaders)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.TerminalId });

            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.POSReturnHeaders)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationId });


            modelBuilder.Entity<InvCustomer>()
             .HasMany(pr => pr.POSReturnHeaders)
             .WithOne()
             .HasForeignKey(pp => new { pp.TenantId, pp.CustId });

            modelBuilder.Entity<InvPOSSalesHeader>()
              .HasMany(pr => pr.POSReturnHeaders)
              .WithOne()
              .HasForeignKey(pp => new { pp.TenantId, pp.InvoiceIdRefernce });


            //InvPOSSalesDetails  
            modelBuilder.Entity<InvPOSSalesHeader>()
            .HasMany(pr => pr.POSSalesDetails)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.InvoiceId });


            modelBuilder.Entity<InvItemUnit>()
           .HasMany(pr => pr.POSSalesDetails)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitId });


            //InvPOSReturnDetails 
            modelBuilder.Entity<InvPOSReturnHeader>()
            .HasMany(pr => pr.POSReturnDetails)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ReturnInvoiceId });


            modelBuilder.Entity<InvItemUnit>()
           .HasMany(pr => pr.POSReturnDetails)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitId });


            //InvPOSSalesPayment
            modelBuilder.Entity<InvPOSSalesHeader>()
            .HasMany(pr => pr.POSSalesPayments)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.InvoiceId });

            modelBuilder.Entity<InvPOSSalesPaymentMethod>()
           .HasMany(pr => pr.POSSalesPayments)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.PaymentMethodId });

            modelBuilder.Entity<InvPOSReturnHeader>()
             .HasMany(pr => pr.POSSalesPayments)
             .WithOne()
             .HasForeignKey(pp => new { pp.TenantId, pp.ReturnVoucherRetId });



            //InvPOSZread    
            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.POSZreads)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId });

            modelBuilder.Entity<InvPOSTerminal>()
           .HasMany(pr => pr.POSZreads)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.TerminalId });

            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.POSZreads)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationId });


            modelBuilder.Entity<AdminUser>()
                 .HasMany(pr => pr.POSZreads)
                 .WithOne()
                 .IsRequired()
                 .HasForeignKey(pp => new { pp.TenantId, pp.UserId });

            //InvPOSZreadDetails   
            modelBuilder.Entity<InvPOSZread>()
            .HasMany(pr => pr.POSZreadDetails)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ZreadId });

            modelBuilder.Entity<InvPOSSalesPaymentMethod>()
              .HasMany(pr => pr.POSZreadDetails)
              .WithOne()
              .IsRequired()
              .HasForeignKey(pp => new { pp.TenantId, pp.PaymentMethodId });


            #endregion

        }
        #endregion Methods
        #region Properties
        //public DbSet<City> Cities { get; set; }

        #endregion Properties
    }
}
