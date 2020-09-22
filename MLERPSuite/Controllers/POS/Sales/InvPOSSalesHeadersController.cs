using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MLERPSuiteBuss.Data;
using MLERPSuiteBuss.Data.Models.Inventory.BE;
using MLERPSuite.Controllers.Shared;
using MLERPSuiteBuss.Shared;
using static MLERPSuiteBuss.Shared.Structures;
using MLERPSuite.Controllers.Shared;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MLERPSuite.Controllers.POS.Sales
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InvPOSSalesHeadersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InvPOSSalesHeadersController(ApplicationDbContext context)
        {
            _context = context;

        }

        [HttpPost]
        public async Task<ActionResult<InvPOSSalesHeader>> AddPOSSalesHeader(InvPOSSalesHeader posSalesHeader)
        {
            JWTTokens jwtTokens = new JWTTokens();
            posSalesHeader.CreatedBy = jwtTokens.GetUserId();
            posSalesHeader.EditedBy = jwtTokens.GetUserId();
            posSalesHeader.TenantId = jwtTokens.GetTenantId();
            posSalesHeader.CreatedDate = DateTime.Now;
            posSalesHeader.EditedDate = DateTime.Now;
            posSalesHeader.InvoiceId = _context.InvPOSSalesHeader.OrderByDescending(u => u.InvoiceId).FirstOrDefault().InvoiceId + 1;

            _context.InvPOSSalesHeader.Add(posSalesHeader);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvPOSSalesHeader", new { id = posSalesHeader.InvoiceId }, posSalesHeader);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<InvPOSSalesHeader>> EditPOSSalesHeader(InvPOSSalesHeader posSalesHeader)
        {
            JWTTokens jwtTokens = new JWTTokens();
            posSalesHeader.EditedBy = jwtTokens.GetUserId();
            posSalesHeader.TenantId = jwtTokens.GetTenantId();
            posSalesHeader.EditedDate = DateTime.Now;
            _context.Entry(posSalesHeader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return CreatedAtAction("GetInvPOSSalesHeader", posSalesHeader);
        }

        [HttpGet("")]
        public async Task<ActionResult<List<GenericList>>> GetDocuments()
        {
            WorkFlow workFlow = new WorkFlow();
            List<GenericList> documents = new List<GenericList>();
            documents = await workFlow.GetWorkFlowDocuments(_context,((int)Enumerations.Workflow.POSSales));
            return documents;
        }

      

        [HttpGet("{position?}/{id?}")]
        [Route("{position?}/{id?}")]
        public async Task<ActionResult<InvPOSSalesHeader>> Navigate(string position, int id)
        {
            JWTTokens jwtTokens = new JWTTokens();
            InvPOSSalesHeader posSalesHeader = new InvPOSSalesHeader();

            if (position == "First")
                posSalesHeader = await _context.InvPOSSalesHeader.Where(p => p.TenantId == jwtTokens.GetTenantId()).OrderBy(u => u.InvoiceId).FirstOrDefaultAsync();
            if (position == "Previous")
                posSalesHeader = await _context.InvPOSSalesHeader.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.InvoiceId < id).OrderByDescending(u => u.InvoiceId).FirstOrDefaultAsync();
            if (position == "Next")
                posSalesHeader = await _context.InvPOSSalesHeader.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.InvoiceId > id).OrderBy(u => u.InvoiceId).FirstOrDefaultAsync();
            if (position == "Last")
                posSalesHeader = await _context.InvPOSSalesHeader.Where(p => p.TenantId == jwtTokens.GetTenantId()).OrderByDescending(u => u.InvoiceId).FirstOrDefaultAsync();
            if (position == "Search")
                posSalesHeader = await _context.InvPOSSalesHeader.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.InvoiceId == id).FirstOrDefaultAsync();

            if (posSalesHeader == null)
            {
                return NotFound();
            }

            return posSalesHeader;
        }

        //[HttpGet("{id?}")]
        //[Route("{id?}")]
        //public async Task<ActionResult<InvPOSSalesHeader>> GetInvPOSSalesHeader( int id)
        //{
        //    JWTTokens jwtTokens = new JWTTokens();
        //    InvPOSSalesHeader posSalesHeader = new InvPOSSalesHeader();

        //    posSalesHeader = await _context.InvPOSSalesHeader.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.InvoiceId == id).FirstOrDefaultAsync();

        //    if (posSalesHeader == null)
        //    {
        //        return NotFound();
        //    }

        //    return posSalesHeader;
        //}

    }

}
