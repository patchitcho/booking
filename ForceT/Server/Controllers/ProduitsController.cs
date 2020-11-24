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
    public class ProduitsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProduitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Produits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produit>>> GetProduit()
        {
            return await _context.Produit.ToListAsync();
        }

        // GET: api/Produits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produit>> GetProduit(int id)
        {
            var produit = await _context.Produit.FindAsync(id);

            if (produit == null)
            {
                return NotFound();
            }

            return produit;
        }

        // PUT: api/Produits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduit(int id, Produit produit)
        {
            if (id != produit.ProduitId)
            {
                return BadRequest();
            }

            _context.Entry(produit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProduitExists(id))
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

        // POST: api/Produits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Produit>> PostProduit(Produit produit)
        {
            _context.Produit.Add(produit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduit", new { id = produit.ProduitId }, produit);
        }

        // DELETE: api/Produits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Produit>> DeleteProduit(int id)
        {
            var produit = await _context.Produit.FindAsync(id);
            if (produit == null)
            {
                return NotFound();
            }

            _context.Produit.Remove(produit);
            await _context.SaveChangesAsync();

            return produit;
        }

        private bool ProduitExists(int id)
        {
            return _context.Produit.Any(e => e.ProduitId == id);
        }
    }
}
