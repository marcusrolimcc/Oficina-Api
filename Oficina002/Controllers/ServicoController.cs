using Microsoft.AspNetCore.Mvc;
using Oficina002.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servico002.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        public Contexto Contexto;

        public ServicoController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<ServicoController>
        [HttpGet]
        [Route("listar")]
        public List<Servico> Listar()
        {
            return Contexto.Servicos.ToList();
        }

        // GET api/<ServicoController>/5
        [HttpGet("detalhe/{id}")]
        public Servico Detalhar(int id)
        {
            return Contexto.Servicos.First(e => e.IdServico == id);
        }

        // POST api/<ServicoController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Servico>> Incluir(Servico servico)
        {
            servico.IdServico = 0;
            Contexto.Servicos.Add(servico);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = servico.IdServico });
        }

        // PUT api/<ServicoController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Servico>> Alterar(Servico servico)
        {
            Contexto.Update(servico);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = servico.IdServico });
        }

        // DELETE api/<ServicoController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Servico servico)
        {
            Contexto.Servicos.Remove(servico);
            Contexto.SaveChanges();
        }
    }
}

