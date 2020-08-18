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
          .IsRequired()
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
          .HasForeignKey(pp => new { pp.WorkFlowId }).OnDelete(DeleteBehavior.Restrict);

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

            modelBuilder.Entity<InvItemUnitOfMeasure>()
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
            base.OnModelCreating(modelBuilder);
        }
        #endregion Methods
        #region Properties
        //public DbSet<City> Cities { get; set; }

        #endregion Properties
    }
}
