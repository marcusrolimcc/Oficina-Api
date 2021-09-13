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
    public class CarroController : ControllerBase
    {
        public Contexto Contexto;

        public CarroController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<CarroController>
        [HttpGet]
        [Route("listar")]
        public List<Carro> Listar()
        {
            return Contexto.Carros.ToList();
        }

        // GET api/<CarroController>/5
        [HttpGet("detalhe/{id}")]
        public Carro Detalhar(int id)
        {
            return Contexto.Carros.First(e => e.IdCarro == id);
        }

        // POST api/<CarroController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Carro>> Incluir(Carro carro)
        {
            carro.IdCarro = 0;
            Contexto.Carros.Add(carro);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = carro.IdCarro });
        }

        // PUT api/<CarroController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Carro>> Alterar(Carro carro)
        {
            Contexto.Update(carro);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = carro.IdCarro });
        }

        // DELETE api/<CarroController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Carro carro)
        {
            Contexto.Carros.Remove(carro);
            Contexto.SaveChanges();
        }
    }
}

