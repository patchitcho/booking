using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proxima.Server.Models;
using Proxima.Shared.Models;

namespace Proxima.Server.Controllers.prox
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabpAntecedentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TabpAntecedentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TabpAntecedents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TabpAntecedent>>> GetTabpAntecedents()
        {
            return await _context.TabpAntecedents.ToListAsync();
        }

        // GET: api/TabpAntecedents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TabpAntecedent>> GetTabpAntecedent(int id)
        {
            var tabpAntecedent = await _context.TabpAntecedents.FindAsync(id);

            if (tabpAntecedent == null)
            {
                return NotFound();
            }

            return tabpAntecedent;
        }

        // PUT: api/TabpAntecedents/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTabpAntecedent(int id, TabpAntecedent tabpAntecedent)
        {
            if (id != tabpAntecedent.AntcdnIdf)
            {
                return BadRequest();
            }

            _context.Entry(tabpAntecedent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TabpAntecedentExists(id))
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

        // POST: api/TabpAntecedents
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TabpAntecedent>> PostTabpAntecedent(TabpAntecedent tabpAntecedent)
        {
            _context.TabpAntecedents.Add(tabpAntecedent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTabpAntecedent", new { id = tabpAntecedent.AntcdnIdf }, tabpAntecedent);
        }

        // DELETE: api/TabpAntecedents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TabpAntecedent>> DeleteTabpAntecedent(int id)
        {
            var tabpAntecedent = await _context.TabpAntecedents.FindAsync(id);
            if (tabpAntecedent == null)
            {
                return NotFound();
            }

            _context.TabpAntecedents.Remove(tabpAntecedent);
            await _context.SaveChangesAsync();

            return tabpAntecedent;
        }

        private bool TabpAntecedentExists(int id)
        {
            return _context.TabpAntecedents.Any(e => e.AntcdnIdf == id);
        }
    }
}
