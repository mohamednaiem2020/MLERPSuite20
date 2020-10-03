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
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MLERPSuite.Controllers.POS.Sales
{
    [Route("api/[controller]")]
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
        [Route("[action]")]
        public async Task<ActionResult<InvPOSSalesHeader>> AddPOSSalesHeader(InvPOSSalesHeader posSalesHeader)
        {
            JWTTokens jwtTokens = new JWTTokens();
            posSalesHeader.InvoiceId = _context.InvPOSSalesHeader.Where(u => u.TenantId == jwtTokens.GetTenantId()).OrderByDescending(u => u.InvoiceId).FirstOrDefault().InvoiceId + 1;
            posSalesHeader.TransStatusId = ((int)Enumerations.TransStatusId.Saved);
            posSalesHeader.WorkFlowId = ((int)Enumerations.Workflow.POSSales);
            posSalesHeader.InvoiceDate = posSalesHeader.InvoiceDate;
            posSalesHeader.HeaderGuidId = Guid.NewGuid();
            posSalesHeader.TenantId = jwtTokens.GetTenantId();
            posSalesHeader.LocationId = jwtTokens.GetLocationId();
            posSalesHeader.TerminalId = jwtTokens.GetTenantId();

            posSalesHeader.CreatedBy = jwtTokens.GetUserId();
            posSalesHeader.EditedBy = jwtTokens.GetUserId();
            posSalesHeader.CreatedDate = DateTime.Now;
            posSalesHeader.EditedDate = DateTime.Now;


            _context.InvPOSSalesHeader.Add(posSalesHeader);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvPOSSalesHeader", new { id = posSalesHeader.InvoiceId }, posSalesHeader);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<InvPOSSalesHeader>> EditPOSSalesHeader(InvPOSSalesHeader posSalesHeader)
        {
            JWTTokens jwtTokens = new JWTTokens();
            posSalesHeader.EditedBy = jwtTokens.GetUserId();
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

        [HttpGet("{position?}/{id?}")]
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
        [HttpGet("")]
        public async Task<ActionResult<List<GenericList>>> GetDocuments()
        {
            WorkFlow workFlow = new WorkFlow();
            List<GenericList> documents = new List<GenericList>();
            documents = await workFlow.GetWorkFlowDocuments(_context, ((int)Enumerations.Workflow.POSSales));
            return documents;
        }
        [HttpGet("{documentId}")]
        public async Task<ActionResult<List<GenericList>>> GetTypes(int documentId)
        {
            SalesTrans salestrans = new SalesTrans();
            List<GenericList> types = new List<GenericList>();
            types = await salestrans.GetSalesTypes(_context);
            return types;
        }



        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<InvPOSSalesDetails>> AddPOSSalesDetails(InvPOSSalesDetails posSalesDetails)
        {
            JWTTokens jwtTokens = new JWTTokens();
            posSalesDetails.TenantId = jwtTokens.GetTenantId();
            posSalesDetails.InvoiceId = posSalesDetails.InvoiceId;

            var maxDetails = _context.InvPOSSalesDetails.Where(u => u.TenantId == jwtTokens.GetTenantId() && u.InvoiceId == posSalesDetails.InvoiceId).OrderByDescending(u => u.DetailsId).FirstOrDefault();
            if (maxDetails != null)
                posSalesDetails.DetailsId = _context.InvPOSSalesDetails.Where(u => u.TenantId == jwtTokens.GetTenantId() && u.InvoiceId == posSalesDetails.InvoiceId).OrderByDescending(u => u.DetailsId).FirstOrDefault().DetailsId + 1;
            else
                posSalesDetails.DetailsId = 1;


            posSalesDetails.ItemId = posSalesDetails.ItemId;
            posSalesDetails.UnitId = posSalesDetails.UnitId;
            posSalesDetails.Quantity = posSalesDetails.Quantity;
            posSalesDetails.Price = posSalesDetails.Price;
            posSalesDetails.TotalAmount = posSalesDetails.TotalAmount;
            posSalesDetails.NetAmount = posSalesDetails.NetAmount;
            posSalesDetails.DetailsGuidId = Guid.NewGuid();


            _context.InvPOSSalesDetails.Add(posSalesDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvPOSSalesDetails", new { id = posSalesDetails.DetailsId }, posSalesDetails);
        }
        [HttpGet("{transId}")]
        public async Task<ActionResult<IEnumerable<InvPOSSalesDetails>>> getDetails(int transId,
        int pageIndex = 0,
        int pageSize = 10)
        {
            SalesTrans salestrans = new SalesTrans();
            List<InvPOSSalesDetails> results = new List<InvPOSSalesDetails>();
            results = await salestrans.getDetails(_context,transId,pageIndex,pageSize);
            return results;
        }

        [HttpGet("{keyword}")]
        public async Task<ActionResult<List<GenericList>>> GetCustomers(string keyword)
        {
            Customers customers = new Customers();
            List<GenericList> customerlst = new List<GenericList>();
            customerlst = await customers.GetCustomers(_context, keyword);
            return customerlst;
        }
        [HttpGet("{keyword}")]
        public async Task<ActionResult<List<GenericList>>> GetItems(string keyword)
        {
            Items items = new Items();
            List<GenericList> itemlst = new List<GenericList>();
            itemlst = await items.GetItems(_context, keyword);
            return itemlst;
        }
        [HttpGet("{itemId}")]
        public async Task<ActionResult<List<GenericList>>> GetItemUnits(int itemId)
        {
            Items items = new Items();
            List<GenericList> itemUnits = new List<GenericList>();
            itemUnits = await items.GetItemUnits(_context, itemId);
            return itemUnits;
        }
        [HttpGet("{itemId?}/{unitId?}")]
        public async Task<ActionResult<decimal>> GetItemUnitPrice(int itemId, int unitId)
        {
            Items items = new Items();
            decimal itemPrice = 0;
            itemPrice = await items.GetItemUnitPrice(_context, itemId, unitId);
            return itemPrice;
        }
    }

}
