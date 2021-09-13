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
    public class AtendimentoController : ControllerBase
    {
        public Contexto Contexto;

        public AtendimentoController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<AtendimentoController>
        [HttpGet]
        [Route("listar")]
        public List<Atendimento> Listar()
        {
            return Contexto.Atendimentos.ToList();
        }

        // GET api/<AtendimentoController>/5
        [HttpGet("detalhe/{id}")]
        public Atendimento Detalhar(int id)
        {
            return Contexto.Atendimentos.First(e => e.IdAtendimento == id);
        }

        // POST api/<AtendimentoController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Atendimento>> Incluir(Atendimento atendimento)
        {
            atendimento.IdAtendimento = 0;
            Contexto.Atendimentos.Add(atendimento);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = atendimento.IdAtendimento });
        }

        // PUT api/<AtendimentoController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Atendimento>> Alterar(Atendimento atendimento)
        {
            Contexto.Update(atendimento);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = atendimento.IdAtendimento });
        }

        // DELETE api/<AtendimentoController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Atendimento atendimento)
        {
                Contexto.Atendimentos.Remove(atendimento);
                Contexto.SaveChanges();
        }
    }
}

