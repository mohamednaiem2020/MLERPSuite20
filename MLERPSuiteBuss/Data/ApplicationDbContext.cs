using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
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
            #region Primary keys
            modelBuilder.Entity<AdminCountry>()
           .HasKey(p => new { p.TenantId, p.CountryId });

            modelBuilder.Entity<AdminProvince>()
           .HasKey(p => new { p.TenantId, p.ProvinceId });

            modelBuilder.Entity<AdminTown>()
           .HasKey(p => new { p.TenantId, p.TownId });

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

            modelBuilder.Entity<AdminTenantLanguage>()
         .HasKey(p => new { p.TenantId, p.LanguageId });

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


            modelBuilder.Entity<InvItemUnitOfMeasurement>()
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
            #endregion

            #region entity relationship

            #region Admin
            //AdminChart
            modelBuilder.Entity<AdminChartLevel>()
            .HasMany(pr => pr.Charts)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ChartLevelId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminChart>()
            .HasMany(pr => pr.Charts)
            .WithOne()

            .HasForeignKey(pp => new { pp.TenantId, pp.ChartParentId }).OnDelete(DeleteBehavior.Restrict);

            //AdminCoding
            modelBuilder.Entity<AdminWFMaster>()
          .HasMany(pr => pr.Codings)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.WorkFlowId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.Codings)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId }).OnDelete(DeleteBehavior.Restrict);


            //AdminModuleScreen
            modelBuilder.Entity<AdminModule>()
          .HasMany(pr => pr.ModuleScreens)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.ModuleId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminScreen>()
       .HasMany(pr => pr.ModuleScreens)
       .WithOne()
       .IsRequired()
       .HasForeignKey(pp => new { pp.ScreenId }).OnDelete(DeleteBehavior.Restrict);

            //AdminObjectLanguage
            modelBuilder.Entity<AdminLanguage>()
          .HasMany(pr => pr.ObjectLanguages)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.LanguageId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminObject>()
      .HasMany(pr => pr.ObjectLanguages)
      .WithOne()
      .IsRequired()
      .HasForeignKey(pp => new { pp.ObjectId }).OnDelete(DeleteBehavior.Restrict);


            //AdminPackageModule
            modelBuilder.Entity<AdminPackage>()
          .HasMany(pr => pr.PackageModules)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.PackageId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminModule>()
      .HasMany(pr => pr.PackageModules)
      .WithOne()
      .IsRequired()
      .HasForeignKey(pp => new { pp.ModuleId }).OnDelete(DeleteBehavior.Restrict);

            //AdminProvince
            modelBuilder.Entity<AdminCountry>()
          .HasMany(pr => pr.Provinces)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.TenantId, pp.CountryId }).OnDelete(DeleteBehavior.Restrict);

            //AdminScreen
            modelBuilder.Entity<AdminRight>()
          .HasMany(pr => pr.Screens)
          .WithOne()
          .HasForeignKey(pp => new { pp.RightId }).OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<AdminScreen>()
   .HasMany(pr => pr.Screens)
   .WithOne()

   .HasForeignKey(pp => new { pp.ScreenParentId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminScreenLevel>()
 .HasMany(pr => pr.Screens)
 .WithOne()
   .IsRequired()
 .HasForeignKey(pp => new { pp.ScreenLevelId }).OnDelete(DeleteBehavior.Restrict);

            //AdminScreenLanguage
            modelBuilder.Entity<AdminScreen>()
            .HasMany(pr => pr.ScreenLanguage)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.ScreenId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminLanguage>()
          .HasMany(pr => pr.ScreenLanguage)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.LanguageId }).OnDelete(DeleteBehavior.Restrict);

            //AdminTenantLanguage
            modelBuilder.Entity<AdminLanguage>()
            .HasMany(pr => pr.TenantLanguages)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.LanguageId }).OnDelete(DeleteBehavior.Restrict);

            //AdminTenantPackage
            modelBuilder.Entity<AdminPackage>()
            .HasMany(pr => pr.TenantPackage)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.PackageId }).OnDelete(DeleteBehavior.Restrict);


            //AdminTown
            modelBuilder.Entity<AdminProvince>()
            .HasMany(pr => pr.Towns)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ProvinceId }).OnDelete(DeleteBehavior.Restrict);


            //AdminUser
            modelBuilder.Entity<AdminChart>()
            .HasMany(pr => pr.Users)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ChartId }).OnDelete(DeleteBehavior.Restrict);

            //AdminWFDocument
            modelBuilder.Entity<AdminWFMaster>()
          .HasMany(pr => pr.WFDocuments)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.WorkFlowId }).OnDelete(DeleteBehavior.Restrict);

            //AdminWFMaster
            modelBuilder.Entity<AdminModule>()
          .HasMany(pr => pr.WFMasters)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.ModuleId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminScreen>()
      .HasMany(pr => pr.WFMasters)
      .WithOne()
      .IsRequired()
      .HasForeignKey(pp => new { pp.ScreenId }).OnDelete(DeleteBehavior.Restrict);


            //AdminWFProcess
            modelBuilder.Entity<AdminWFStep>()
            .HasMany(pr => pr.WFProcesses)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.StepId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminWFStepStatus>()
         .HasMany(pr => pr.WFProcesses)
         .WithOne()
         .IsRequired()
         .HasForeignKey(pp => new { pp.StepStatusId }).OnDelete(DeleteBehavior.Restrict);

            //AdminWFStep
            modelBuilder.Entity<AdminWFMaster>()
           .HasMany(pr => pr.WFSteps)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.WorkFlowId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<AdminActor>()
            .HasMany(pr => pr.WFSteps)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ActorId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminWFStep>()
              .HasMany(pr => pr.WFSteps)
              .WithOne()

              .HasForeignKey(pp => new { pp.TenantId, pp.NextStepId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.WFSteps)
            .WithOne()

            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId }).OnDelete(DeleteBehavior.Restrict);

            //AdminWfStepAction
            modelBuilder.Entity<AdminWFStep>()
              .HasMany(pr => pr.WFStepAction)
              .WithOne()
              .IsRequired()
              .HasForeignKey(pp => new { pp.TenantId, pp.StepId }).OnDelete(DeleteBehavior.Restrict);

            //AdminWFTransList
            modelBuilder.Entity<AdminWFMaster>()
          .HasMany(pr => pr.WFTransList)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.WorkFlowId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminWFTransStatus>()
        .HasMany(pr => pr.WFTransList)
        .WithOne()
        .IsRequired()
        .HasForeignKey(pp => new { pp.TransStatusId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<AdminWFDocument>()
          .HasMany(pr => pr.WFTransList)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminWFDocument>()
              .HasMany(pr => pr.WFTransList)
              .WithOne()
              .IsRequired()
              .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId }).OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Inventory
            //InvCustomer
            modelBuilder.Entity<AdminProvince>()
      .HasMany(pr => pr.Customers)
      .WithOne()

      .HasForeignKey(pp => new { pp.TenantId, pp.ProvinceId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<AdminTown>()
              .HasMany(pr => pr.Customers)
              .WithOne()

              .HasForeignKey(pp => new { pp.TenantId, pp.TownId }).OnDelete(DeleteBehavior.Restrict);



            //InvItemCategory

            modelBuilder.Entity<InvItemCategory>()
              .HasMany(pr => pr.ItemCategories)
              .WithOne()
              .HasForeignKey(pp => new { pp.TenantId, pp.CatParentId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvItemCategoryLevel>()
            .HasMany(pr => pr.ItemCategories)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.CatLevelId }).OnDelete(DeleteBehavior.Restrict);

            //InvItemMaster           
            modelBuilder.Entity<InvItemCategory>()
            .HasMany(pr => pr.ItemMasters)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.CatId }).OnDelete(DeleteBehavior.Restrict);

            //InvItemUnits         
            modelBuilder.Entity<InvItemMaster>()
            .HasMany(pr => pr.ItemUnits)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ItemId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvItemUnitOfMeasurement>()
          .HasMany(pr => pr.ItemUnits)
          .WithOne()
          .IsRequired()
          .HasForeignKey(pp => new { pp.TenantId, pp.UnitId }).OnDelete(DeleteBehavior.Restrict);


            //InvItemUnitBarcodes       
            modelBuilder.Entity<InvItemUnit>()
            .HasMany(pr => pr.ItemUnitBarcodes)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitId }).OnDelete(DeleteBehavior.Restrict);


            //InvItemUnitMatrix      
            modelBuilder.Entity<InvItemUnit>()
            .HasMany(pr => pr.ItemUnitMatrixesFrom)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitIdFrom }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<InvItemUnit>()
            .HasMany(pr => pr.ItemUnitMatrixesTo)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitIdTo }).OnDelete(DeleteBehavior.Restrict);


            //InvLocation      
            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.Locations)
            .WithOne()

            .HasForeignKey(pp => new { pp.TenantId, pp.LocationParentId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<InvLocationLevel>()
           .HasMany(pr => pr.Locations)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.LocationLevelId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvPriceHeader>()
             .HasMany(pr => pr.Locations)
             .WithOne()

             .HasForeignKey(pp => new { pp.TenantId, pp.PriceListId }).OnDelete(DeleteBehavior.Restrict);


            //InvPriceDetails      
            modelBuilder.Entity<InvPriceHeader>()
            .HasMany(pr => pr.PriceDetails)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.PriceListId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvItemUnit>()
              .HasMany(pr => pr.PriceDetails)
              .WithOne()
              .IsRequired()
              .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitId }).OnDelete(DeleteBehavior.Restrict);


            //InvPOSTerminal      
            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.POSTerminals)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationId }).OnDelete(DeleteBehavior.Restrict);

            //InvPOSSalesHeader      
            modelBuilder.Entity<InvPOSSalesType>()
    .HasMany(pr => pr.POSSalesHeaders)
    .WithOne()
    .IsRequired()
    .HasForeignKey(pp => new { pp.InvPOSSalesTypeId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminWFMaster>()
.HasMany(pr => pr.POSSalesHeaders)
.WithOne()
.IsRequired()
.HasForeignKey(pp => new { pp.WorkFlowId }).OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.POSSalesHeaders)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvPOSTerminal>()
           .HasMany(pr => pr.POSSalesHeaders)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.TerminalId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.POSSalesHeaders)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<InvCustomer>()
             .HasMany(pr => pr.POSSalesHeaders)
             .WithOne()

             .HasForeignKey(pp => new { pp.TenantId, pp.CustId }).OnDelete(DeleteBehavior.Restrict);



            //InvPOSReturnHeader  
            modelBuilder.Entity<InvPOSReturnType>()
        .HasMany(pr => pr.POSReturnHeaders)
        .WithOne()
        .IsRequired()
        .HasForeignKey(pp => new { pp.POSReturnTypeId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminWFMaster>()
   .HasMany(pr => pr.POSReturnHeaders)
   .WithOne()
   .IsRequired()
   .HasForeignKey(pp => new { pp.WorkFlowId }).OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.POSReturnHeaders)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvPOSTerminal>()
           .HasMany(pr => pr.POSReturnHeaders)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.TerminalId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.POSReturnHeaders)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<InvCustomer>()
             .HasMany(pr => pr.POSReturnHeaders)
             .WithOne()

             .HasForeignKey(pp => new { pp.TenantId, pp.CustId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvPOSSalesHeader>()
              .HasMany(pr => pr.POSReturnHeaders)
              .WithOne()

              .HasForeignKey(pp => new { pp.TenantId, pp.InvoiceIdRefernce }).OnDelete(DeleteBehavior.Restrict);


            //InvPOSSalesDetails  
            modelBuilder.Entity<InvPOSSalesHeader>()
            .HasMany(pr => pr.POSSalesDetails)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.InvoiceId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<InvItemUnit>()
           .HasMany(pr => pr.POSSalesDetails)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitId }).OnDelete(DeleteBehavior.Restrict);


            //InvPOSReturnDetails 
            modelBuilder.Entity<InvPOSReturnHeader>()
            .HasMany(pr => pr.POSReturnDetails)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ReturnInvoiceId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<InvItemUnit>()
           .HasMany(pr => pr.POSReturnDetails)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.ItemId, pp.UnitId }).OnDelete(DeleteBehavior.Restrict);


            //InvPOSSalesPayment
            modelBuilder.Entity<InvPOSSalesHeader>()
            .HasMany(pr => pr.POSSalesPayments)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.InvoiceId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvPOSSalesPaymentMethod>()
           .HasMany(pr => pr.POSSalesPayments)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.PaymentMethodId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvPOSReturnHeader>()
             .HasMany(pr => pr.POSSalesPayments)
             .WithOne()

             .HasForeignKey(pp => new { pp.TenantId, pp.ReturnVoucherRetId }).OnDelete(DeleteBehavior.Restrict);



            //InvPOSZread    

            modelBuilder.Entity<AdminWFMaster>()
.HasMany(pr => pr.POSZreads)
.WithOne()
.IsRequired()
.HasForeignKey(pp => new { pp.WorkFlowId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdminWFDocument>()
            .HasMany(pr => pr.POSZreads)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.WorkFlowId, pp.DocumentId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvPOSTerminal>()
           .HasMany(pr => pr.POSZreads)
           .WithOne()
           .IsRequired()
           .HasForeignKey(pp => new { pp.TenantId, pp.TerminalId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvLocation>()
            .HasMany(pr => pr.POSZreads)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.LocationId }).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<AdminUser>()
                 .HasMany(pr => pr.POSZreads)
                 .WithOne()
                 .IsRequired()
                 .HasForeignKey(pp => new { pp.TenantId, pp.UserId }).OnDelete(DeleteBehavior.Restrict);

            //InvPOSZreadDetails   
            modelBuilder.Entity<InvPOSZread>()
            .HasMany(pr => pr.POSZreadDetails)
            .WithOne()
            .IsRequired()
            .HasForeignKey(pp => new { pp.TenantId, pp.ZreadId }).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InvPOSSalesPaymentMethod>()
              .HasMany(pr => pr.POSZreadDetails)
              .WithOne()
              .IsRequired()
              .HasForeignKey(pp => new { pp.TenantId, pp.PaymentMethodId }).OnDelete(DeleteBehavior.Restrict);


            #endregion


            #endregion

            #region Data seeding
            modelBuilder.Entity<AdminObject>().HasData(
                new AdminObject
                {
                    ObjectId = 10000001,
                    ObjectDescription = "Package name",
                    IsFixedList = 1
                }
                ,
                 new AdminObject
                 {
                     ObjectId = 10000002,
                     ObjectDescription = "Package description",
                     IsFixedList = 1
                 }
                  ,
                 new AdminObject
                 {
                     ObjectId = 10000003,
                     ObjectDescription = "Module",
                     IsFixedList = 1
                 }
                 ,
                 new AdminObject
                 {
                     ObjectId = 10000004,
                     ObjectDescription = "Right",
                     IsFixedList = 1
                 }
                 ,
                 new AdminObject
                 {
                     ObjectId = 10000005,
                     ObjectDescription = "Screen level",
                     IsFixedList = 1
                 }
                  ,
                 new AdminObject
                 {
                     ObjectId = 10000006,
                     ObjectDescription = "Screen",
                     IsFixedList = 1
                 }
                  ,
                 new AdminObject
                 {
                     ObjectId = 10000007,
                     ObjectDescription = "Workflow master",
                     IsFixedList = 1
                 }
                 ,
                 new AdminObject
                 {
                     ObjectId = 10000008,
                     ObjectDescription = "Step Status",
                     IsFixedList = 1
                 }
                 ,
                 new AdminObject
                 {
                     ObjectId = 10000009,
                     ObjectDescription = "Trans Status",
                     IsFixedList = 1
                 }
                  ,
                   new AdminObject
                   {
                       ObjectId = 10000010,
                       ObjectDescription = "Document",
                       IsFixedList = 0
                   }
                  ,
                 new AdminObject
                 {
                     ObjectId = 10100001,
                     ObjectDescription = "Return type",
                     IsFixedList = 1
                 }
                  ,
                 new AdminObject
                 {
                     ObjectId = 10100002,
                     ObjectDescription = "Sales type",
                     IsFixedList = 1
                 },
                 new AdminObject
                 {
                     ObjectId = 10100003,
                     ObjectDescription = "Customer",
                     IsFixedList = 0
                 },
                 new AdminObject
                 {
                     ObjectId = 10100004,
                     ObjectDescription = "Item",
                     IsFixedList = 0
                 }
            );

            modelBuilder.Entity<InvPOSSalesType>().HasData(
         new InvPOSSalesType
         {
           InvPOSSalesTypeId=1,
         }
     );

            modelBuilder.Entity<AdminObjectLanguage>().HasData(
           new AdminObjectLanguage
           {
               TenantId = 1,
               LanguageId = 1,
               ObjectId = 10100002,
               RowId = 1,
               RowDescription = "Sales Invoice"
           }
       );

            modelBuilder.Entity<AdminLanguage>().HasData(
          new AdminLanguage
          {
              LanguageId = 1,
              IsRightToLeft = 0,
              LanguageDescription = "English"
          },
           new AdminLanguage
           {
               LanguageId = 2,
               IsRightToLeft = 1,
               LanguageDescription = "عربي"
           }
      );
            modelBuilder.Entity<AdminModule>().HasData(
                     new AdminModule
                     {
                         ModuleId = 100,
                         ModuleCode = "100",
                         IsDisabled = 0,
                         ModuleIcon = "",
                         ModuleOrder = 1,
                         ModuleURL = "",
                         Records3DigitsPrefix = "100",
                     },
                      new AdminModule
                      {
                          ModuleId = 101,
                          ModuleCode = "101",
                          IsDisabled = 0,
                          ModuleIcon = "",
                          ModuleOrder = 1,
                          ModuleURL = "",
                          Records3DigitsPrefix = "101",
                      }
                 );
            modelBuilder.Entity<AdminRight>().HasData(
                 new AdminRight
                 {
                     RightId = 10101001

                 }
             );

            modelBuilder.Entity<AdminScreenLevel>().HasData(
                  new AdminScreenLevel
                  {
                      ScreenLevelId = 1


                  },
                   new AdminScreenLevel
                   {
                       ScreenLevelId = 2
                   }
              );


            modelBuilder.Entity<AdminScreen>().HasData(
                   new AdminScreen
                   {
                       ScreenId = 10101000,
                       IsDisabled = 0,
                       ScreenIcon = "",
                       ScreenIsLeaf = 0,
                       ScreenLevelId = 1,
                       ScreenLevelId1 = 10101000,
                       ScreenOrder = 1,
                       ScreenURL = ""


                   },
                    new AdminScreen
                    {
                        ScreenId = 10101001,
                        IsDisabled = 0,
                        RightId = 10101001,
                        ScreenParentId = 10101000,
                        ScreenIcon = "",
                        ScreenIsLeaf = 1,
                        ScreenLevelId = 1,
                        ScreenLevelId1 = 10101000,
                        ScreenLevelId2 = 10101001,
                        ScreenOrder = 2,
                        ScreenURL = "",

                    }
               );


            modelBuilder.Entity<AdminModuleScreen>().HasData(
                  new AdminModuleScreen
                  {
                      ScreenId = 10101001,
                      ModuleId = 101
                  }
              );

            modelBuilder.Entity<AdminWFMaster>().HasData(
                new AdminWFMaster
                {
                    ModuleId = 101,
                    ScreenId = 10101001,
                    WorkFlowId = 10101
                }
            );
            //Temp data
            modelBuilder.Entity<AdminTenant>().HasData(
           new AdminTenant
           {
               TenantId = 1
             ,
               TenantDescription = "first client"
           },
            new AdminTenant
            {
                TenantId = 2,

                TenantDescription = "second client"
            }
       );

            modelBuilder.Entity<AdminActor>().HasData(
              new AdminActor
              {
                  TenantId = 1,
                  ActorId = 1
              }
          );

            modelBuilder.Entity<AdminChartLevel>().HasData(
           new AdminChartLevel
           {
               TenantId = 1,
               ChartLevelId = 1,
               ChartCodeLength = 1,
               CreatedBy = 1,
               CreatedDate = DateTime.Now,
               EditedBy = 1,
               EditedDate = DateTime.Now
           },
            new AdminChartLevel
            {
                TenantId = 1,
                ChartLevelId = 2,
                ChartCodeLength = 1,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                EditedBy = 1,
                EditedDate = DateTime.Now
            }
       );

            modelBuilder.Entity<AdminChart>().HasData(
              new AdminChart
              {
                  TenantId = 1,
                  ChartId = 1,
                  ChartCode = "1",
                  ChartIsLeaf = 0,
                  ChartLevelId = 1,
                  ChartLevelId1 = 1,
                  CreatedBy = 1,
                  CreatedDate = DateTime.Now,
                  EditedBy = 1,
                  EditedDate = DateTime.Now
              },
               new AdminChart
               {
                   TenantId = 1,
                   ChartId = 2,
                   ChartCode = "2",
                   ChartIsLeaf = 1,
                   ChartParentId = 1,
                   ChartLevelId = 2,
                   ChartLevelId1 = 1,
                   ChartLevelId2 = 2,
                   CreatedBy = 1,
                   CreatedDate = DateTime.Now,
                   EditedBy = 1,
                   EditedDate = DateTime.Now
               }
          );



            modelBuilder.Entity<AdminCurrency>().HasData(
            new AdminCurrency
            {
                TenantId = 1,
                CurrencyId = 1,
                CurrencyCode = "KWD",
                DigitCount = 3,
                IsLocalCurrency = 1,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                EditedBy = 1,
                EditedDate = DateTime.Now

            }
        );

            modelBuilder.Entity<AdminWFDocument>().HasData(
               new AdminWFDocument
               {
                   TenantId = 1,
                   DocumentId = 10101001,
                   IsDisabled = 1,
                   WorkFlowId = 10101
               }
           );

            modelBuilder.Entity<AdminObjectLanguage>().HasData(
              new AdminObjectLanguage
              {
                  TenantId = 1,
                  LanguageId = 1,
                  ObjectId = 10000010,
                  RowId = 10101001,
                  RowDescription = "Sales Invoice"
              }
          );

          
            
            modelBuilder.Entity<AdminCoding>().HasData(
            new AdminCoding
            {
                TenantId = 1,
                CurrentNumber = "00000",
                DocumentId = 10101001,
                NumberLength = 6,
                PrefixCode = "Inv",
                SplitCharcter = "-",
                WithLocation = 1,
                WithMonthYear = 1,
                WithPrefix = 1,
                WorkFlowId = 10101

            }
        );
            modelBuilder.Entity<AdminUser>().HasData(
              new AdminUser
              {
                  TenantId = 1,
                  LoginUserName = "Mohamed",
                  UserFullName = "Mohamed",
                  UserId = 1,
                  ChartId = 2,
                  IsAdmin = 0,
                  IsDisabled = 0,
                  Password = "111",
                  CreatedBy = 1,
                  CreatedDate = DateTime.Now,
                  EditedBy = 1,
                  EditedDate = DateTime.Now
              }
          );

            modelBuilder.Entity<AdminWFStep>().HasData(
           new AdminWFStep
           {
               TenantId = 1,
               ActorId = 1,
               IsFirstStep = 1,
               StepId = 10101001,
               WorkFlowId = 10101
           }
       );
            modelBuilder.Entity<AdminCountry>().HasData(
     new AdminCountry
     {
         TenantId = 1,
         CountryId = 1



     }
 );
            modelBuilder.Entity<AdminProvince>().HasData(
       new AdminProvince
       {
           TenantId = 1,
           CountryId = 1,
           ProvinceId = 1



       }
   );

            modelBuilder.Entity<AdminTown>().HasData(
     new AdminTown
     {
         TenantId = 1,

         ProvinceId = 1,
         TownId = 1



     }
 );

            modelBuilder.Entity<InvCustomer>().HasData(
         new InvCustomer
         {
             TenantId = 1,
             CustId = 1,
             CustCode = "1",
             IsDisabled = 0,
             BlockNo = 1,
             BuildingNo = "",
             CustContactPerson = "",
             CustEmail1 = "",
             CustFaxNo = "",
             CustFullAddress = "",
             CustMobileNo = "",
             CustRef = "",
             CustTelNo = "",
             CustWebsite = "",
             FlatNo = "",
             StreetNo = "",
             ProvinceId = 1,
             TownId = 1,
             CreatedBy = 1,
             CreatedDate = DateTime.Now,
             EditedBy = 1,
             EditedDate = DateTime.Now,
         }
     );


            modelBuilder.Entity<AdminObjectLanguage>().HasData(
           new AdminObjectLanguage
           {
               TenantId = 1,
               LanguageId = 1,
               ObjectId = 10100003,
               RowId = 1,
               RowDescription = "Sadia"
           }
       );

            modelBuilder.Entity<InvItemCategoryLevel>().HasData(
                  new InvItemCategoryLevel
                  {
                      TenantId = 1,
                      CatLevelId = 1,
                      CatCodeLength = 1,
                      CreatedBy = 1,
                      CreatedDate = DateTime.Now,
                      EditedBy = 1,
                      EditedDate = DateTime.Now,

                  }, new InvItemCategoryLevel
                  {
                      TenantId = 1,
                      CatLevelId = 2,
                      CatCodeLength = 1,
                      CreatedBy = 1,
                      CreatedDate = DateTime.Now,
                      EditedBy = 1,
                      EditedDate = DateTime.Now,

                  }
              );

            modelBuilder.Entity<InvItemCategory>().HasData(
                 new InvItemCategory
                 {
                     TenantId = 1,
                     CatCode = "1",
                     CatId = 1,
                     CatIsLeaf = 0,
                     CatLevelId = 1,
                     CatLevelId1 = 1,
                     CreatedBy = 1,
                     CreatedDate = DateTime.Now,
                     EditedBy = 1,
                     EditedDate = DateTime.Now,
                 }
                 ,
                     new InvItemCategory
                     {
                         TenantId = 1,
                         CatCode = "2",
                         CatId = 2,
                         CatIsLeaf = 1,
                         CatLevelId = 2,
                         CatLevelId1 = 1,
                         CatLevelId2 = 2,
                         CatParentId = 1,
                         CreatedBy = 1,
                         CreatedDate = DateTime.Now,
                         EditedBy = 1,
                         EditedDate = DateTime.Now,

                     }
             );

            modelBuilder.Entity<InvItemMaster>().HasData(
              new InvItemMaster
              {
                  TenantId = 1,
                  CatId = 2,
                  BaseToBigFactorCashed = Convert.ToDecimal(0.08333),
                  BaseUnitIdCashed = 1,
                  BigToBaseFactorCashed = 12,
                  BigUnitIdCashed = 2,
                  IsDisabled = 0,
                  ItemCode = "1001",
                  ItemId = 1,
                  CreatedBy = 1,
                  CreatedDate = DateTime.Now,
                  EditedBy = 1,
                  EditedDate = DateTime.Now,
              },
               new InvItemMaster
               {
                   TenantId = 1,
                   CatId = 2,
                   BaseToBigFactorCashed = Convert.ToDecimal(0.08333),
                   BaseUnitIdCashed = 1,
                   BigToBaseFactorCashed = 12,
                   BigUnitIdCashed = 2,
                   IsDisabled = 0,
                   ItemCode = "1002",
                   ItemId = 2,
                   CreatedBy = 1,
                   CreatedDate = DateTime.Now,
                   EditedBy = 1,
                   EditedDate = DateTime.Now,
               }

          );
            modelBuilder.Entity<AdminObjectLanguage>().HasData(
         new AdminObjectLanguage
         {
             TenantId = 1,
             LanguageId = 1,
             ObjectId = 10100004,
             RowId = 1,
             RowDescription = "Sadia chickent 12 pc"
         }
     );

            modelBuilder.Entity<AdminObjectLanguage>().HasData(
       new AdminObjectLanguage
       {
           TenantId = 1,
           LanguageId = 1,
           ObjectId = 10100004,
           RowId = 2,
           RowDescription = "Sadia burger 12 pc"
       }
   );


            modelBuilder.Entity<InvItemUnitOfMeasurement>().HasData(
       new InvItemUnitOfMeasurement
       {
           TenantId = 1,
           UnitId = 1,
           UnitCode = "PC",
           UnitArabicName = "PC",
           UnitEnglishName = "PC",
           CreatedBy = 1,
           CreatedDate = DateTime.Now,
           EditedBy = 1,
           EditedDate = DateTime.Now,
       },
       new InvItemUnitOfMeasurement
       {
           TenantId = 1,
           UnitId = 2,
           UnitCode = "Packet",
           UnitArabicName = "Packet",
           UnitEnglishName = "Packet",
           CreatedBy = 1,
           CreatedDate = DateTime.Now,
           EditedBy = 1,
           EditedDate = DateTime.Now,
       }

   );

            modelBuilder.Entity<InvItemUnit>().HasData(
          new InvItemUnit
          {
              TenantId = 1,
              ItemId = 1,
              UnitId = 1,
              FactorToBaseUnit = 1,
              IsBaseUnit = 1,
              IsDisabled = 0,
              CreatedBy = 1,
              CreatedDate = DateTime.Now,
              EditedBy = 1,
              EditedDate = DateTime.Now,
          },
          new InvItemUnit
          {
              TenantId = 1,
              ItemId = 1,
              UnitId = 2,
              FactorToBaseUnit = 12,
              IsBaseUnit = 0,
              IsDisabled = 0,
              CreatedBy = 1,
              CreatedDate = DateTime.Now,
              EditedBy = 1,
              EditedDate = DateTime.Now,
          }

      );

            modelBuilder.Entity<InvItemUnitMatrix>().HasData(
         new InvItemUnitMatrix
         {
             TenantId = 1,
             ItemId = 1,
             UnitIdFrom = 1,
             UnitIdTo = 2,
             Factor = Convert.ToDecimal(0.08333)
         },
         new InvItemUnitMatrix
         {
             TenantId = 1,
             ItemId = 1,
             UnitIdFrom = 2,
             UnitIdTo = 1,
             Factor = 12
         }

     ); ;

            modelBuilder.Entity<InvLocationLevel>().HasData(
       new InvLocationLevel
       {
           TenantId = 1,
           LocationLevelId = 1,
           LocationCodeLength = 1,
           CreatedBy = 1,
           CreatedDate = DateTime.Now,
           EditedBy = 1,
           EditedDate = DateTime.Now,
       },
         new InvLocationLevel
         {
             TenantId = 1,
             LocationLevelId = 2,
             LocationCodeLength = 1,
             CreatedBy = 1,
             CreatedDate = DateTime.Now,
             EditedBy = 1,
             EditedDate = DateTime.Now,
         }
   );

            modelBuilder.Entity<InvLocation>().HasData(
      new InvLocation
      {
          TenantId = 1,
          LocationLevelId = 1,

          LocationCode = "1",
          LocationId = 1,
          LocationIsLeaf = 0,
          LocationLevelId1 = 1,
          CreatedBy = 1,
          CreatedDate = DateTime.Now,
          EditedBy = 1,
          EditedDate = DateTime.Now,
      },
        new InvLocation
        {
            TenantId = 1,
            LocationLevelId = 2,

            LocationCode = "2",
            LocationId = 2,
            LocationIsLeaf = 1,
            LocationLevelId1 = 1,
            LocationLevelId2 = 2,
            CreatedBy = 1,
            CreatedDate = DateTime.Now,
            EditedBy = 1,
            EditedDate = DateTime.Now,
        }
  );

            modelBuilder.Entity<InvPOSTerminal>().HasData(
     new InvPOSTerminal
     {
         TenantId = 1,
         LocationId = 2,
         TerminalId = 1,
         TerminalCode = "101",
         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         EditedBy = 1,
         EditedDate = DateTime.Now,
     }
 );

            modelBuilder.Entity<InvPriceHeader>().HasData(
   new InvPriceHeader
   {
       TenantId = 1,
       PriceListId = 1,
       PriceListCode = "1",
       CreatedBy = 1,
       CreatedDate = DateTime.Now,
       EditedBy = 1,
       EditedDate = DateTime.Now,
   }
);
            modelBuilder.Entity<InvPriceDetails>().HasData(
 new InvPriceDetails
 {
     TenantId = 1,
     PriceListId = 1,
     ItemId = 1,
     Price = 10,
     UnitId = 1
 },
  new InvPriceDetails
  {
      TenantId = 1,
      PriceListId = 1,
      ItemId = 1,
      Price = 120,
      UnitId = 2
  }
);
            #endregion
            base.OnModelCreating(modelBuilder);
        }
        #endregion Methods
        #region Properties
        public DbSet<InvItemUnitOfMeasurement> InvItemUnitOfMeasurement { get; set; }
        public DbSet<AdminWFDocument> AdminWFDocument { get; set; }
        public DbSet<AdminObjectLanguage> AdminObjectLanguage { get; set; }
        public DbSet<InvPOSSalesHeader> InvPOSSalesHeader { get; set; }
        public DbSet<InvPOSSalesType> InvPOSSalesType { get; set; }
        #endregion Properties
    }
}
