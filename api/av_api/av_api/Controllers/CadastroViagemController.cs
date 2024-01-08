using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using av_api.Context;
using av_api.Models;

namespace av_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroViagemController : ControllerBase
    {
        private readonly DataContext _context;

        public CadastroViagemController(DataContext context)
        {
            _context = context;
        }

        // GET: api/CadastroViagems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CadastroViagem>>> GetCadastroViagem()
        {
            return await _context.CadastroViagem.ToListAsync();
        }

        // GET: api/CadastroViagems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CadastroViagem>> GetCadastroViagem(int id)
        {
            var cadastroViagem = await _context.CadastroViagem.FindAsync(id);

            if (cadastroViagem == null)
            {
                return NotFound();
            }

            return cadastroViagem;
        }

        // PUT: api/CadastroViagems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCadastroViagem(int id, CadastroViagem cadastroViagem)
        {
            if (id != cadastroViagem.idCadastro)
            {
                return BadRequest();
            }

            _context.Entry(cadastroViagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CadastroViagemExists(id))
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

        // POST: api/CadastroViagems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CadastroViagem>> PostCadastroViagem(CadastroViagem cadastroViagem)
        {
            _context.CadastroViagem.Add(cadastroViagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCadastroViagem", new { id = cadastroViagem.idCadastro }, cadastroViagem);
        }

        // DELETE: api/CadastroViagems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCadastroViagem(int id)
        {
            var cadastroViagem = await _context.CadastroViagem.FindAsync(id);
            if (cadastroViagem == null)
            {
                return NotFound();
            }

            _context.CadastroViagem.Remove(cadastroViagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CadastroViagemExists(int id)
        {
            return _context.CadastroViagem.Any(e => e.idCadastro == id);
        }
    }
}
