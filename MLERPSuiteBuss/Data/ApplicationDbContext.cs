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
            #endregion

        }
        #endregion Methods
        #region Properties
        //public DbSet<City> Cities { get; set; }

        #endregion Properties
    }
}
