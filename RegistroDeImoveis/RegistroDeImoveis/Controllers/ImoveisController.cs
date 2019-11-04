using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroDeImoveis.Model;

namespace RegistroDeImoveis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImoveisController : ControllerBase
    {
        private readonly WebApiContext _context;

        public ImoveisController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Imoveis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Imoveis>>> GetImoveis()
        {
            return await _context.Imoveis.ToListAsync();
        }

        // GET: api/Imoveis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Imoveis>> GetImoveis(int id)
        {
            var imoveis = await _context.Imoveis.FindAsync(id);

            if (imoveis == null)
            {
                return NotFound();
            }

            return imoveis;
        }

        // PUT: api/Imoveis/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImoveis(int id, Imoveis imoveis)
        {
            if (id != imoveis.Id)
            {
                return BadRequest();
            }

            _context.Entry(imoveis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImoveisExists(id))
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

        // POST: api/Imoveis
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Imoveis>> PostImoveis(Imoveis imoveis)
        {
            _context.Imoveis.Add(imoveis);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImoveis", new { id = imoveis.Id }, imoveis);
        }

        // DELETE: api/Imoveis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Imoveis>> DeleteImoveis(int id)
        {
            var imoveis = await _context.Imoveis.FindAsync(id);
            if (imoveis == null)
            {
                return NotFound();
            }

            _context.Imoveis.Remove(imoveis);
            await _context.SaveChangesAsync();

            return imoveis;
        }

        private bool ImoveisExists(int id)
        {
            return _context.Imoveis.Any(e => e.Id == id);
        }
    }
}
