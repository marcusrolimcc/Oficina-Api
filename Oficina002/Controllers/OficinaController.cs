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
    public class OficinaController : ControllerBase
    {
        public Contexto Contexto;

        public OficinaController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<OficinaController>
        [HttpGet]
        [Route("listar")]
        public List<Oficina> Listar()
        {
            return Contexto.Oficinas.ToList();
        }

        // GET api/<OficinaController>/5
        [HttpGet("detalhe/{id}")]
        public Oficina Detalhar(int id)
        {
            return Contexto.Oficinas.First(e => e.IdOficina == id);
        }

        // POST api/<OficinaController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Oficina>> Incluir(Oficina oficina)
        {
            oficina.IdOficina = 0;
            Contexto.Oficinas.Add(oficina);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = oficina.IdOficina });
        }

        // PUT api/<OficinaController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Oficina>> Alterar(Oficina oficina)
        {
            Contexto.Update(oficina);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = oficina.IdOficina });
        }

        // DELETE api/<OficinaController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Oficina oficina)
        {
            Contexto.Oficinas.Remove(oficina);
            Contexto.SaveChanges();
        }
    }
}

