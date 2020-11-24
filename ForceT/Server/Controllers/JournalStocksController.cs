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
    public class EntStocksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntStocksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JournalStocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JournalStock>>> GetJournalStock()
        {
            return await _context.JournalStock.ToListAsync();
        }

        // GET: api/JournalStocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JournalStock>> GetJournalStock(int id)
        {
            var journalStock = await _context.JournalStock.FindAsync(id);

            if (journalStock == null)
            {
                return NotFound();
            }

            return journalStock;
        }

        // PUT: api/JournalStocks/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJournalStock(int id, JournalStock journalStock)
        {
            if (id != journalStock.JournalStockId)
            {
                return BadRequest();
            }

            _context.Entry(journalStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JournalStockExists(id))
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

        // POST: api/JournalStocks
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<JournalStock>> PostJournalStock(JournalStock journalStock)
        {
            _context.JournalStock.Add(journalStock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJournalStock", new { id = journalStock.JournalStockId }, journalStock);
        }

        // DELETE: api/JournalStocks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JournalStock>> DeleteJournalStock(int id)
        {
            var journalStock = await _context.JournalStock.FindAsync(id);
            if (journalStock == null)
            {
                return NotFound();
            }

            _context.JournalStock.Remove(journalStock);
            await _context.SaveChangesAsync();

            return journalStock;
        }

        private bool JournalStockExists(int id)
        {
            return _context.JournalStock.Any(e => e.JournalStockId == id);
        }
    }
}
