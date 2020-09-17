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
        // GET: api/UnitsOfMeasurement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> GetUnitOfMeasurement(int id)
        {
            var unitOfMeasurement = await _context.InvItemUnitOfMeasurement.FindAsync(id);

            if (unitOfMeasurement == null)
            {
                return NotFound();
            }

            return unitOfMeasurement;
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> PutUnitOfMeasurement(InvItemUnitOfMeasurement unitOfMeasurement)
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
                if (!UnitOfMeasurementExists(unitOfMeasurement.UnitId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInvItemUnitOfMeasurement", unitOfMeasurement);
        }

        // POST: api/UnitsOfMeasurement
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> PostUnitOfMeasurement(InvItemUnitOfMeasurement unitOfMeasurement)
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
        public ActionResult<InvItemUnitOfMeasurement> Navigate(string position, int id)
        {
            JWTTokens jwtTokens = new JWTTokens();
            InvItemUnitOfMeasurement unitOfMeasurement = new InvItemUnitOfMeasurement();

            if (position == "First")
                unitOfMeasurement = _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId()).OrderBy(u => u.UnitId).FirstOrDefault();
            if (position == "Previous")
                unitOfMeasurement = _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.UnitId < id).OrderByDescending(u => u.UnitId).FirstOrDefault();
            if (position == "Next")
                unitOfMeasurement = _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.UnitId > id).OrderBy(u => u.UnitId).FirstOrDefault();
            if (position == "Last")
                unitOfMeasurement = _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId()).OrderByDescending(u => u.UnitId).FirstOrDefault();
            if (position == "Search")
                unitOfMeasurement = _context.InvItemUnitOfMeasurement.Where(p => p.TenantId == jwtTokens.GetTenantId() && p.UnitId == id).FirstOrDefault();

            if (unitOfMeasurement == null)
            {
                return NotFound();
            }

            return unitOfMeasurement;
        }
        private bool UnitOfMeasurementExists(int id)
        {
            return _context.InvItemUnitOfMeasurement.Any(e => e.UnitId == id);
        }

        [HttpPost]
        [Route("IsDupeUnitOfMeasurement")]
        public bool IsDupeUnitOfMeasurement(InvItemUnitOfMeasurement unitOfMeasurement)
        {
            return _context.InvItemUnitOfMeasurement.Any(
            e => e.UnitCode == unitOfMeasurement.UnitCode
            && e.UnitId != unitOfMeasurement.UnitId
            );
        }
    }
}
