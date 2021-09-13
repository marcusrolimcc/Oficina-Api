using Microsoft.AspNetCore.Mvc;
using Oficina002.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Oficina002.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        public Contexto Contexto;

        public MarcaController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<MarcaController>
        [HttpGet]
        [Route("listar")]
        public List<Marca> Listar()
        {
            return Contexto.Marcas.ToList();
        }

        // GET api/<MarcaController>/5
        [HttpGet("detalhe/{id}")]
        public Marca Detalhar(int id)
        {
            return Contexto.Marcas.First(e => e.IdMarca == id);
        }

        // POST api/<MarcaController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Marca>> Incluir(Marca marca)
        {
            marca.IdMarca = 0;
            Contexto.Marcas.Add(marca);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = marca.IdMarca });
        }

        // PUT api/<MarcaController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Marca>> Alterar(Marca marca)
        {
            Contexto.Update(marca);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = marca.IdMarca });
        }

        // DELETE api/<MarcaController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Marca marca)
        {
            Contexto.Marcas.Remove(marca);
            Contexto.SaveChanges();
        }
    }
}

