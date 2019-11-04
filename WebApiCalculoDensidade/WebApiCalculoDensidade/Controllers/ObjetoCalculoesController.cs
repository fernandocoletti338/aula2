using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCalculoDensidade.Model;

namespace WebApiCalculoDensidade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetoCalculoesController : ControllerBase
    {
        private readonly WebApiContext _context;

        public ObjetoCalculoesController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/ObjetoCalculoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObjetoCalculo>>> Getcalculos()
        {
            return await _context.calculos.ToListAsync();
        }

        // GET: api/ObjetoCalculoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ObjetoCalculo>> GetObjetoCalculo(int id)
        {
            var objetoCalculo = await _context.calculos.FindAsync(id);

            if (objetoCalculo == null)
            {
                return NotFound();
            }

            return objetoCalculo;
        }

        // PUT: api/ObjetoCalculoes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjetoCalculo(int id, ObjetoCalculo objetoCalculo)
        {
            if (id != objetoCalculo.Id)
            {
                return BadRequest();
            }

            _context.Entry(objetoCalculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjetoCalculoExists(id))
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

        // POST: api/ObjetoCalculoes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ObjetoCalculo>> PostObjetoCalculo(ObjetoCalculo objetoCalculo)
        {
            objetoCalculo.Massa = objetoCalculo.Densidade * objetoCalculo.Volume;
            objetoCalculo.Peso = objetoCalculo.Massa * objetoCalculo.Gravidade;

            _context.calculos.Add(objetoCalculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObjetoCalculo", new { id = objetoCalculo.Id }, objetoCalculo);
        }

        // DELETE: api/ObjetoCalculoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ObjetoCalculo>> DeleteObjetoCalculo(int id)
        {
            var objetoCalculo = await _context.calculos.FindAsync(id);
            if (objetoCalculo == null)
            {
                return NotFound();
            }

            _context.calculos.Remove(objetoCalculo);
            await _context.SaveChangesAsync();

            return objetoCalculo;
        }

        private bool ObjetoCalculoExists(int id)
        {
            return _context.calculos.Any(e => e.Id == id);
        }
    }
}
