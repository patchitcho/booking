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
    public class StockInternesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StockInternesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StockInternes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockInterne>>> GetStockInterne()
        {
            return await _context.StockInterne.ToListAsync();
        }

        // GET: api/StockInternes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StockInterne>> GetStockInterne(int id)
        {
            var stockInterne = await _context.StockInterne.FindAsync(id);

            if (stockInterne == null)
            {
                return NotFound();
            }

            return stockInterne;
        }

        // PUT: api/StockInternes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStockInterne(int id, StockInterne stockInterne)
        {
            if (id != stockInterne.StockId)
            {
                return BadRequest();
            }

            _context.Entry(stockInterne).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockInterneExists(id))
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

        // POST: api/StockInternes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<StockInterne>> PostStockInterne(StockInterne stockInterne)
        {
            _context.StockInterne.Add(stockInterne);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStockInterne", new { id = stockInterne.StockId }, stockInterne);
        }

        // DELETE: api/StockInternes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StockInterne>> DeleteStockInterne(int id)
        {
            var stockInterne = await _context.StockInterne.FindAsync(id);
            if (stockInterne == null)
            {
                return NotFound();
            }

            _context.StockInterne.Remove(stockInterne);
            await _context.SaveChangesAsync();

            return stockInterne;
        }

        private bool StockInterneExists(int id)
        {
            return _context.StockInterne.Any(e => e.StockId == id);
        }
    }
}
