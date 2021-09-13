using Microsoft.AspNetCore.Mvc;
using Oficina002.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tipo_Pagamento002.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tipo_PagamentoController : ControllerBase
    {
        public Contexto Contexto;

        public Tipo_PagamentoController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<Tipo_PagamentoController>
        [HttpGet]
        [Route("listar")]
        public List<Tipo_Pagamento> Listar()
        {
            return Contexto.Tipo_Pagamentos.ToList();
        }

        // GET api/<Tipo_PagamentoController>/5
        [HttpGet("detalhe/{id}")]
        public Tipo_Pagamento Detalhar(int id)
        {
            return Contexto.Tipo_Pagamentos.First(e => e.IdTipoPagamento == id);
        }

        // POST api/<Tipo_PagamentoController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Tipo_Pagamento>> Incluir(Tipo_Pagamento tipo_Pagamento)
        {
            tipo_Pagamento.IdTipoPagamento = 0;
            Contexto.Tipo_Pagamentos.Add(tipo_Pagamento);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = tipo_Pagamento.IdTipoPagamento });
        }

        // PUT api/<Tipo_PagamentoController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Tipo_Pagamento>> Alterar(Tipo_Pagamento tipo_Pagamento)
        {
            Contexto.Update(tipo_Pagamento);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = tipo_Pagamento.IdTipoPagamento });
        }

        // DELETE api/<Tipo_PagamentoController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Tipo_Pagamento tipo_Pagamento)
        {
            Contexto.Tipo_Pagamentos.Remove(tipo_Pagamento);
            Contexto.SaveChanges();
        }
    }
}

