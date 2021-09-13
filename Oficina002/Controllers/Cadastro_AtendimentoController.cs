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
    public class Cadastro_AtendimentoController : ControllerBase
    {
        public Contexto Contexto;

        public Cadastro_AtendimentoController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<Cadastro_AtendimentoController>
        [HttpGet]
        [Route("listar")]
        public List<Cadastro_Atendimento> Listar()
        {
            return Contexto.Cadastro_Atendimentos.ToList();
        }

        // GET api/<Cadastro_AtendimentoController>/5
        [HttpGet("detalhe/{id}")]
        public Cadastro_Atendimento Detalhar(int id)
        {
            return Contexto.Cadastro_Atendimentos.First(e => e.IdCadastroAtendimento == id);
        }

        // POST api/<Cadastro_AtendimentoController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Cadastro_Atendimento>> Incluir(Cadastro_Atendimento cadastro_Atendimento)
        {
            cadastro_Atendimento.IdCadastroAtendimento = 0;
            Contexto.Cadastro_Atendimentos.Add(cadastro_Atendimento);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = cadastro_Atendimento.IdCadastroAtendimento });
        }

        // PUT api/<Cadastro_AtendimentoController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Cadastro_Atendimento>> Alterar(Cadastro_Atendimento cadastro_Atendimento)
        {
            Contexto.Update(cadastro_Atendimento);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = cadastro_Atendimento.IdCadastroAtendimento });
        }

        // DELETE api/<Cadastro_AtendimentoController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Cadastro_Atendimento cadastro_Atendimento)
        {
            Contexto.Cadastro_Atendimentos.Remove(cadastro_Atendimento);
            Contexto.SaveChanges();
        }
    }
}

