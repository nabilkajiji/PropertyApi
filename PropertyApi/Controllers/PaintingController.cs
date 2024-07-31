using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyApi.Models;

namespace PropertyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaintingController : ControllerBase
    {
        private readonly ArtContext _context;
        public PaintingController(ArtContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPaintings()
        {
            return Ok(await _context.Paintings
                .Include(p => p.Artist)
                .ToArrayAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetPaintings(int id)
        {
            var painting = await _context.Paintings
                .Include(p => p.Artist)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (painting == null)
            {
                return NotFound();
            }
            return Ok(painting);
        }
        [HttpPost]
        public async Task<ActionResult<Painting>> PostPaintings(Painting painting)
        {
            
            if (!ModelState.IsValid) {
                return BadRequest();
            }
            
            _context.Paintings.Add(painting);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetProduct",
                new { id = painting.Id },
                painting);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> PutProduct(int id, Painting painting)
        {
            if (id != painting.Id)
            {
                return BadRequest();
            }

            _context.Entry(painting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Paintings.Any(p => p.Id == id))
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
        [HttpDelete("{id}")]
        public async Task<ActionResult<Painting>> Deletepainting(int id)
        {
            var painting = await _context.Paintings.FindAsync(id);
            if (painting == null)
            {
                return NotFound();
            }

            _context.Paintings.Remove(painting);
            await _context.SaveChangesAsync();

            return painting;
        }
    }
}


   
