using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MLERPSuiteBuss.Shared;
using MLERPSuiteBuss.Data;
using Microsoft.EntityFrameworkCore;

namespace MLERPSuite.Controllers.Shared
{
    public class Items
    {

        public async Task<List<Structures.GenericList>> GetItems(ApplicationDbContext context, string keyword )
        {
            List<Structures.GenericList> types = new List<Structures.GenericList>();
            JWTTokens jwtTokens = new JWTTokens();
            types = await context.InvItemMaster.Where(p => p.ItemCode == keyword && p.TenantId== jwtTokens.GetTenantId())
                .Join(context.AdminObjectLanguage.Where(p => p.LanguageId == jwtTokens.GetLanguageId() && (p.ObjectId == (int)Enumerations.ObjectType.Item) && p.TenantId == jwtTokens.GetTenantId())
                , InvItemMaster => InvItemMaster.ItemId, AdminObjectLanguage => AdminObjectLanguage.RowId,
            (InvItemMaster, AdminObjectLanguage) => new Structures.GenericList()
            {
                id = InvItemMaster.ItemId
            ,
                description = AdminObjectLanguage.RowDescription
            }).ToListAsync();
            return types;
        }

        public async Task<List<Structures.GenericList>> GetItemUnits(ApplicationDbContext context, int itemId)
        {
            List<Structures.GenericList> itemUnits = new List<Structures.GenericList>();
            JWTTokens jwtTokens = new JWTTokens();
            itemUnits = await context.InvItemUnit.Where(p => p.ItemId == itemId && p.TenantId == jwtTokens.GetTenantId())
                .Join(context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId())
                , itemUnits => itemUnits.UnitId, InvItemUnitOfMeasurement => InvItemUnitOfMeasurement.UnitId,
            (itemUnits, InvItemUnitOfMeasurement) => new Structures.GenericList()
            {
                id = itemUnits.UnitId
            ,
                description = InvItemUnitOfMeasurement.UnitCode
            }).ToListAsync();
            return itemUnits;
        }

        public async Task<decimal> GetItemUnitPrice(ApplicationDbContext context, int itemId, int unitId)
        {
            decimal price = 0;
            JWTTokens jwtTokens = new JWTTokens();
            var record = await context.InvPriceDetails.Where(p => p.ItemId == itemId && p.UnitId == unitId && p.TenantId == jwtTokens.GetTenantId()).FirstOrDefaultAsync();
            price = record.Price;
            return price;
        }
    }
}
