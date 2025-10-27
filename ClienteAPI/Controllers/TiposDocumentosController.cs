
using ClienteAPI.Data;
using ClienteAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClienteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposDocumentosController : ControllerBase
    {
        private readonly BdClientesContext _context;

        public TiposDocumentosController(BdClientesContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposDocumentos>>> GetTiposDocumentos()
        {
            return await _context.TiposDocumentos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TiposDocumentos>> GetTiposDocumentos(int id)
        {
            var tipoDocumento = await _context.TiposDocumentos.FindAsync(id);

            if (tipoDocumento == null)
            {
                return NotFound();
            }

            return tipoDocumento;
        }
    }
}