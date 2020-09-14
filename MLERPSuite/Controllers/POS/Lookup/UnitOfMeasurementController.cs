using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MLERPSuiteBuss.Data;
using MLERPSuiteBuss.Data.Models.Inventory.BE;

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
        public async Task<IActionResult> PutUnitOfMeasurement(int id, InvItemUnitOfMeasurement unitOfMeasurement)
        {
            if (id != unitOfMeasurement.UnitId)
            {
                return BadRequest();
            }

            _context.Entry(unitOfMeasurement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitOfMeasurementExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UnitsOfMeasurement
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> PostUnitOfMeasurement(InvItemUnitOfMeasurement unitOfMeasurement)
        {
            unitOfMeasurement.CreatedBy = 1;
            unitOfMeasurement.CreatedDate = DateTime.Now;
            unitOfMeasurement.EditedBy = 1;
            unitOfMeasurement.EditedDate = DateTime.Now;
            unitOfMeasurement.TenantId = 1;
            unitOfMeasurement.UnitId = 1;

            _context.InvItemUnitOfMeasurement.Add(unitOfMeasurement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvItemUnitOfMeasurement", new { id = unitOfMeasurement.UnitId }, unitOfMeasurement);
        }

        // DELETE: api/UnitsOfMeasurement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvItemUnitOfMeasurement>> DeleteUnitOfMeasurement(int id)
        {
            var unitOfMeasurement = await _context.InvItemUnitOfMeasurement.FindAsync(id);
            if (unitOfMeasurement == null)
            {
                return NotFound();
            }

            _context.InvItemUnitOfMeasurement.Remove(unitOfMeasurement);
            await _context.SaveChangesAsync();

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
