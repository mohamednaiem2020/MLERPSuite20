using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MLERPSuiteBuss.Shared;
using MLERPSuiteBuss.Data;
using Microsoft.EntityFrameworkCore;

namespace MLERPSuite.Controllers.Shared
{
    public class Customers
    {
        public async Task<List<Structures.GenericList>> GetCustomers(ApplicationDbContext context, string keyword)
        {
            List<Structures.GenericList> types = new List<Structures.GenericList>();
            JWTTokens jwtTokens = new JWTTokens();
            types = await context.InvCustomer.Where(p => p.CustCode == keyword)
                .Join(context.AdminObjectLanguage.Where(p => p.LanguageId == jwtTokens.GetLanguageId() && (p.ObjectId == (int)Enumerations.ObjectType.Customer))
                , InvCustomer => InvCustomer.CustId, AdminObjectLanguage => AdminObjectLanguage.RowId,
            (InvCustomer, AdminObjectLanguage) => new Structures.GenericList()
            {
                id = InvCustomer.CustId
            ,
                description = AdminObjectLanguage.RowDescription
            }).ToListAsync();
            return types;
        }

    }
}
