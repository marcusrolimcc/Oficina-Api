using Microsoft.AspNetCore.Mvc;
using Oficina002.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tipo_Servico002.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tipo_ServicoController : ControllerBase
    {
        public Contexto Contexto;

        public Tipo_ServicoController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<Tipo_ServicoController>
        [HttpGet]
        [Route("listar")]
        public List<Tipo_Servico> Listar()
        {
            return Contexto.Tipo_Servicos.ToList();
        }

        // GET api/<Tipo_ServicoController>/5
        [HttpGet("detalhe/{id}")]
        public Tipo_Servico Detalhar(int id)
        {
            return Contexto.Tipo_Servicos.First(e => e.IdTipoServico == id);
        }

        // POST api/<Tipo_ServicoController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Tipo_Servico>> Incluir(Tipo_Servico tipo_Servico)
        {
            tipo_Servico.IdTipoServico = 0;
            Contexto.Tipo_Servicos.Add(tipo_Servico);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = tipo_Servico.IdTipoServico });
        }

        // PUT api/<Tipo_ServicoController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Tipo_Servico>> Alterar(Tipo_Servico tipo_Servico)
        {
            Contexto.Update(tipo_Servico);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = tipo_Servico.IdTipoServico });
        }

        // DELETE api/<Tipo_ServicoController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Tipo_Servico tipo_Servico)
        {
            Contexto.Tipo_Servicos.Remove(tipo_Servico);
            Contexto.SaveChanges();
        }
    }
}

