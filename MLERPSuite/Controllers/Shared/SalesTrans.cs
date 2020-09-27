using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MLERPSuiteBuss.Shared;
using MLERPSuiteBuss.Data;
using Microsoft.EntityFrameworkCore;

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
    }
}
