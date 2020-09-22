using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MLERPSuiteBuss.Shared;
using MLERPSuiteBuss.Data;
using Microsoft.EntityFrameworkCore;

namespace MLERPSuite.Controllers.Shared
{
    public class WorkFlow
    {
        public async Task<List<Structures.GenericList>> GetWorkFlowDocuments(ApplicationDbContext context, int workFlowId)
        {
            List<Structures.GenericList> documents = new List<Structures.GenericList>();
            JWTTokens jwtTokens = new JWTTokens();
            documents = await context.AdminWFDocument.Where(p => p.WorkFlowId == workFlowId && p.TenantId == jwtTokens.GetTenantId())
                .Join(context.AdminObjectLanguage.Where(p => p.LanguageId == jwtTokens.GetLanguageId()), AdminWFDocument => AdminWFDocument.DocumentId, AdminObjectLanguage =>
                AdminObjectLanguage.RowId,
            (AdminWFDocument, AdminObjectLanguage) => new Structures.GenericList()
            {
                id = AdminWFDocument.DocumentId
            ,
                description = AdminObjectLanguage.RowDescription
            }).ToListAsync();
            return documents;
        }
    }
}
