using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArabicProject.Data;
using ArabicProject.Models;

namespace ArabicProject.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AdApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdEntree>>> GetAdEntree()
        {
            return await _context.AdEntree.ToListAsync();
        }

        // GET: api/AdApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdEntree>> GetAdEntree(int id)
        {
            var adEntree = await _context.AdEntree.FindAsync(id);

            if (adEntree == null)
            {
                return NotFound();
            }

            return adEntree;
        }

        // PUT: api/AdApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdEntree(int id, AdEntree adEntree)
        {
            if (id != adEntree.Id)
            {
                return BadRequest();
            }

            _context.Entry(adEntree).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdEntreeExists(id))
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

        // POST: api/AdApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AdEntree>> PostAdEntree(AdEntree adEntree)
        {
            _context.AdEntree.Add(adEntree);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdEntree", new { id = adEntree.Id }, adEntree);
        }

        // DELETE: api/AdApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AdEntree>> DeleteAdEntree(int id)
        {
            var adEntree = await _context.AdEntree.FindAsync(id);
            if (adEntree == null)
            {
                return NotFound();
            }

            _context.AdEntree.Remove(adEntree);
            await _context.SaveChangesAsync();

            return adEntree;
        }

        private bool AdEntreeExists(int id)
        {
            return _context.AdEntree.Any(e => e.Id == id);
        }
    }
}
