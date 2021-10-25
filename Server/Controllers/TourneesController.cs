using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proxima.Server.Models;
using Proxima.Shared.Models;

namespace Proxima.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourneesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TourneesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Tournees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tournee>>> GetTournee()
        {
            return await _context.Tournee.ToListAsync();
        }

        // GET: api/Tournees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tournee>> GetTournee(int id)
        {
            var tournee = await _context.Tournee.FindAsync(id);

            if (tournee == null)
            {
                return NotFound();
            }

            return tournee;
        }

        // PUT: api/Tournees/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTournee(int id, Tournee tournee)
        {
            if (id != tournee.TourneeId)
            {
                return BadRequest();
            }

            _context.Entry(tournee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourneeExists(id))
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

        // POST: api/Tournees
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tournee>> PostTournee(Tournee tournee)
        {
            _context.Tournee.Add(tournee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTournee", new { id = tournee.TourneeId }, tournee);
        }

        // DELETE: api/Tournees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tournee>> DeleteTournee(int id)
        {
            var tournee = await _context.Tournee.FindAsync(id);
            if (tournee == null)
            {
                return NotFound();
            }

            _context.Tournee.Remove(tournee);
            await _context.SaveChangesAsync();

            return tournee;
        }

        private bool TourneeExists(int id)
        {
            return _context.Tournee.Any(e => e.TourneeId == id);
        }
    }
}
