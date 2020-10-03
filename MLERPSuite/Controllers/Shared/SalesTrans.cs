using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MLERPSuiteBuss.Shared;
using MLERPSuiteBuss.Data;
using Microsoft.EntityFrameworkCore;
using MLERPSuiteBuss.Data.Models.Inventory.BE;

namespace MLERPSuite.Controllers.Shared
{
    public class SalesTrans
    {
        public async Task<List<Structures.GenericList>> GetSalesTypes(ApplicationDbContext context)
        {
            List<Structures.GenericList> types = new List<Structures.GenericList>();
            JWTTokens jwtTokens = new JWTTokens();
            types = await context.InvPOSSalesType
                .Join(context.AdminObjectLanguage.Where(p => p.LanguageId == jwtTokens.GetLanguageId() && (p.ObjectId == (int)Enumerations.ObjectType.Sales_type))
                , InvPOSSalesType => InvPOSSalesType.InvPOSSalesTypeId, AdminObjectLanguage => AdminObjectLanguage.RowId,
            (InvPOSSalesType, AdminObjectLanguage) => new Structures.GenericList()
            {
                id = InvPOSSalesType.InvPOSSalesTypeId
            ,
                description = AdminObjectLanguage.RowDescription
            }).ToListAsync();
            return types;
        }
        public async Task<List<InvPOSSalesDetails>> getDetails(ApplicationDbContext context, int transId, int pageIndex, int pageSize)
        {
            List<InvPOSSalesDetails> result = new List<InvPOSSalesDetails>();
            JWTTokens jwtTokens = new JWTTokens();

            result = await context.InvPOSSalesDetails.Where(a => a.InvoiceId == transId && a.TenantId == jwtTokens.GetTenantId())
                  .Skip(pageIndex * pageSize).Take(pageSize)
                  .Join(context.InvItemUnitOfMeasurement.Where(a => a.TenantId == jwtTokens.GetTenantId()), detailsUnits => detailsUnits.UnitId, units => units.UnitId,
                        (detailsUnits, units) => new { detailsUnits, units })
                  .Join(context.InvItemMaster.Where(a => a.TenantId == jwtTokens.GetTenantId()), detailsItems => detailsItems.detailsUnits.ItemId, items => items.ItemId,
                        (detailsItems, items) => new { detailsItems, items })
                  .Select(all => new InvPOSSalesDetails
                  {

                      itemCode = all.items.ItemCode,
                      unitCode = all.detailsItems.units.UnitCode,
                      Price = all.detailsItems.detailsUnits.Price,
                      Quantity = all.detailsItems.detailsUnits.Quantity,
                      TotalAmount = all.detailsItems.detailsUnits.TotalAmount,
                  })
                  .ToListAsync();

            return result;


        }
    }
}
