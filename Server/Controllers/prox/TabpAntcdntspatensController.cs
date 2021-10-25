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
    public class TabpAntcdntspatensController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TabpAntcdntspatensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TabpAntcdntspatens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TabpAntcdntspaten>>> GetTabpAntcdntspatens()
        {
            return await _context.TabpAntcdntspatens.ToListAsync();
        }

        // GET: api/TabpAntcdntspatens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TabpAntcdntspaten>> GetTabpAntcdntspaten(int id)
        {
            var tabpAntcdntspaten = await _context.TabpAntcdntspatens.FindAsync(id);

            if (tabpAntcdntspaten == null)
            {
                return NotFound();
            }

            return tabpAntcdntspaten;
        }

        // PUT: api/TabpAntcdntspatens/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTabpAntcdntspaten(int id, TabpAntcdntspaten tabpAntcdntspaten)
        {
            if (id != tabpAntcdntspaten.AntcptnIdf)
            {
                return BadRequest();
            }

            _context.Entry(tabpAntcdntspaten).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TabpAntcdntspatenExists(id))
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

        // POST: api/TabpAntcdntspatens
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TabpAntcdntspaten>> PostTabpAntcdntspaten(TabpAntcdntspaten tabpAntcdntspaten)
        {
            _context.TabpAntcdntspatens.Add(tabpAntcdntspaten);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTabpAntcdntspaten", new { id = tabpAntcdntspaten.AntcptnIdf }, tabpAntcdntspaten);
        }

        // DELETE: api/TabpAntcdntspatens/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TabpAntcdntspaten>> DeleteTabpAntcdntspaten(int id)
        {
            var tabpAntcdntspaten = await _context.TabpAntcdntspatens.FindAsync(id);
            if (tabpAntcdntspaten == null)
            {
                return NotFound();
            }

            _context.TabpAntcdntspatens.Remove(tabpAntcdntspaten);
            await _context.SaveChangesAsync();

            return tabpAntcdntspaten;
        }

        private bool TabpAntcdntspatenExists(int id)
        {
            return _context.TabpAntcdntspatens.Any(e => e.AntcptnIdf == id);
        }
    }
}
