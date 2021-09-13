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
    public class ClienteController : ControllerBase
    {
        public Contexto Contexto;

        public ClienteController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        [Route("listar")]
        public List<Cliente> Listar()
        {
            return Contexto.Clientes.ToList();
        }

        // GET api/<ClienteController>/5
        [HttpGet("detalhe/{id}")]
        public Cliente Detalhar(int id)
        {
            return Contexto.Clientes.First(e => e.IdCliente == id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Cliente>> Incluir(Cliente cliente)
        {
            cliente.IdCliente = 0;
            Contexto.Clientes.Add(cliente);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = cliente.IdCliente });
        }

        // PUT api/<ClienteController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Cliente>> Alterar(Cliente cliente)
        {
            Contexto.Update(cliente);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = cliente.IdCliente });
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Cliente cliente)
        {
            Contexto.Clientes.Remove(cliente);
            Contexto.SaveChanges();
        }
    }
}

