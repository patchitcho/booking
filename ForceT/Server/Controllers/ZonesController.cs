using ForceT.Server.Models;
using ForceT.Server.Services.Excel;
using ForceT.Server.Services.Pdf;
using ForceT.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForceT.Server.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ZonesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IPdfCreateService _pdfCreat;
        private readonly IExcelCreatService _excelCreat;

        public ZonesController(ApplicationDbContext context, IPdfCreateService PdfCreat, IExcelCreatService ExcelCreat)
        {
            _context = context;
            _pdfCreat = PdfCreat;
            _excelCreat = ExcelCreat;
        }

        // GET: api/Zones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Zone>>> GetZone()
        {
            return await _context.Zone.ToListAsync();
            //return await GetAllZones();
        }

        private async Task<IEnumerable<Zone>> GetAllZones()
        {
            return await _context.Zone.ToListAsync();
        }

        // GET: api/Zones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Zone>> GetZone(int id)
        {
            var zone = await _context.Zone.FindAsync(id);

            if (zone == null)
            {
                return NotFound();
            }

            return zone;
        }

        // PUT: api/Zones/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZone(int id, Zone zone)
        {
            if (id != zone.zoneId)
            {
                return BadRequest();
            }

            _context.Entry(zone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZoneExists(id))
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

        // POST: api/Zones
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Zone>> PostZone(Zone zone)
        {
            _context.Zone.Add(zone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZone", new { id = zone.zoneId }, zone);
        }

        // DELETE: api/Zones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Zone>> DeleteZone(int id)
        {
            var zone = await _context.Zone.FindAsync(id);
            if (zone == null)
            {
                return NotFound();
            }

            _context.Zone.Remove(zone);
            await _context.SaveChangesAsync();

            return zone;
        }

        [HttpGet("exportpdf")]
        public IActionResult ExportZonesPdf()
        {
            var zones = GetZone().Result.Value;
            var p = from zone in zones select new { zone = zone.zone, ville = zone.ville, code_postale = zone.codepostal };
            return Ok(_pdfCreat.ExportPdf(p, "Liste des zones"));
        }

        [HttpGet("exportexcel")]
        public IActionResult ExportZonesExcel()
        {
            var zones = GetZone().Result.Value;
            var p = from zone in zones select new { zone = zone.zone, ville = zone.ville, code_postale = zone.codepostal };
            return Ok(_excelCreat.ExportExcel(p, "Liste des zones"));
        }

        private bool ZoneExists(int id)
        {
            return _context.Zone.Any(e => e.zoneId == id);
        }
    }
}
