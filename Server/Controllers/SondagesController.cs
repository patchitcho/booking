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
    public class SondagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SondagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Sondages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sondage>>> GetSondage()
        {
            return await _context.Sondage.ToListAsync();
        }

        // GET: api/Sondages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sondage>> GetSondage(int id)
        {
            var sondage = await _context.Sondage.FindAsync(id);

            if (sondage == null)
            {
                return NotFound();
            }

            return sondage;
        }

        // PUT: api/Sondages/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSondage(int id, Sondage sondage)
        {
            if (id != sondage.SondageId)
            {
                return BadRequest();
            }

            _context.Entry(sondage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SondageExists(id))
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

        // POST: api/Sondages
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Sondage>> PostSondage(Sondage sondage)
        {
            _context.Sondage.Add(sondage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSondage", new { id = sondage.SondageId }, sondage);
        }

        // DELETE: api/Sondages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sondage>> DeleteSondage(int id)
        {
            var sondage = await _context.Sondage.FindAsync(id);
            if (sondage == null)
            {
                return NotFound();
            }

            _context.Sondage.Remove(sondage);
            await _context.SaveChangesAsync();

            return sondage;
        }

        private bool SondageExists(int id)
        {
            return _context.Sondage.Any(e => e.SondageId == id);
        }
    }
}
