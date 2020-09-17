using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MLERPSuiteBuss.Data;
using MLERPSuiteBuss.Data.Models.Inventory.BE;
using MLERPSuite.Controllers.Shared;

namespace MLERPSuite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsOfMeasurementController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UnitsOfMeasurementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/UnitsOfMeasurement
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> AddUnitOfMeasurement(InvItemUnitOfMeasurement unitOfMeasurement)
        {
            JWTTokens jwtTokens = new JWTTokens();
            unitOfMeasurement.CreatedBy = jwtTokens.GetUserId();
            unitOfMeasurement.EditedBy = jwtTokens.GetUserId();
            unitOfMeasurement.TenantId = jwtTokens.GetTenantId();
            unitOfMeasurement.CreatedDate = DateTime.Now;
            unitOfMeasurement.EditedDate = DateTime.Now;
            unitOfMeasurement.UnitId = _context.InvItemUnitOfMeasurement.OrderByDescending(u => u.UnitId).FirstOrDefault().UnitId + 1;

            _context.InvItemUnitOfMeasurement.Add(unitOfMeasurement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvItemUnitOfMeasurement", new { id = unitOfMeasurement.UnitId }, unitOfMeasurement);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> EditUnitOfMeasurement(InvItemUnitOfMeasurement unitOfMeasurement)
        {
            JWTTokens jwtTokens = new JWTTokens();
            unitOfMeasurement.EditedBy = jwtTokens.GetUserId();
            unitOfMeasurement.TenantId = jwtTokens.GetTenantId();
            unitOfMeasurement.EditedDate = DateTime.Now;
            _context.Entry(unitOfMeasurement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return CreatedAtAction("GetInvItemUnitOfMeasurement", unitOfMeasurement);
        }

        // DELETE: api/UnitsOfMeasurement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> DeleteUnitOfMeasurement(int id)
        {
            JWTTokens jwtTokens = new JWTTokens();
            InvItemUnitOfMeasurement unitOfMeasurement = await _context.InvItemUnitOfMeasurement.FindAsync(jwtTokens.GetTenantId(), id);

            _context.InvItemUnitOfMeasurement.Remove(unitOfMeasurement);
            await _context.SaveChangesAsync();

            return unitOfMeasurement;
        }

        // GET: api/UnitsOfMeasurement/0/10
        [HttpGet("{position?}/{id?}")]
        [Route("{position?}/{id?}")]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> Navigate(string position, int id)
        {
            JWTTokens jwtTokens = new JWTTokens();
            InvItemUnitOfMeasurement unitOfMeasurement = new InvItemUnitOfMeasurement();

            if (position == "First")
                unitOfMeasurement = await _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId()).OrderBy(u => u.UnitId).FirstOrDefaultAsync();
            if (position == "Previous")
                unitOfMeasurement = await _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.UnitId < id).OrderByDescending(u => u.UnitId).FirstOrDefaultAsync();
            if (position == "Next")
                unitOfMeasurement = await _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.UnitId > id).OrderBy(u => u.UnitId).FirstOrDefaultAsync();
            if (position == "Last")
                unitOfMeasurement = await _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId()).OrderByDescending(u => u.UnitId).FirstOrDefaultAsync();
            if (position == "Search")
                unitOfMeasurement = await _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.UnitId == id).FirstOrDefaultAsync();

            if (unitOfMeasurement == null)
            {
                return NotFound();
            }

            return unitOfMeasurement;
        }
 
        private bool IsDupeUnitOfMeasurement(InvItemUnitOfMeasurement unitOfMeasurement)
        {
            return _context.InvItemUnitOfMeasurement.Any(
            e => e.UnitCode == unitOfMeasurement.UnitCode
            && e.UnitId != unitOfMeasurement.UnitId
            );
        }
    }
}
