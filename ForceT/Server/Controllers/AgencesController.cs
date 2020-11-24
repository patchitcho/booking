using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ForceT.Server.Models;
using ForceT.Shared.Models;

namespace ForceT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AgencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Agences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agence>>> GetAgence()
        {
            return await _context.Agence.ToListAsync();
        }

        // GET: api/Agences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agence>> GetAgence(int id)
        {
            var agence = await _context.Agence.FindAsync(id);

            if (agence == null)
            {
                return NotFound();
            }

            return agence;
        }

        // PUT: api/Agences/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgence(int id, Agence agence)
        {
            if (id != agence.AgenceId)
            {
                return BadRequest();
            }

            _context.Entry(agence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgenceExists(id))
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

        // POST: api/Agences
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Agence>> PostAgence(Agence agence)
        {
            _context.Agence.Add(agence);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgence", new { id = agence.AgenceId }, agence);
        }

        // DELETE: api/Agences/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Agence>> DeleteAgence(int id)
        {
            var agence = await _context.Agence.FindAsync(id);
            if (agence == null)
            {
                return NotFound();
            }

            _context.Agence.Remove(agence);
            await _context.SaveChangesAsync();

            return agence;
        }

        private bool AgenceExists(int id)
        {
            return _context.Agence.Any(e => e.AgenceId == id);
        }
    }
}
