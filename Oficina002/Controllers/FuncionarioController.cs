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
    public class FuncionarioController : ControllerBase
    {
        public Contexto Contexto;

        public FuncionarioController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: api/<FuncionarioController>
        [HttpGet]
        [Route("listar")]
        public List<Funcionario> Listar()
        {
            return Contexto.Funcionarios.ToList();
        }

        // GET api/<FuncionarioController>/5
        [HttpGet("detalhe/{id}")]
        public Funcionario Detalhar(int id)
        {
            return Contexto.Funcionarios.First(e => e.IdFuncionario == id);
        }

        // POST api/<FuncionarioController>
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Funcionario>> Incluir(Funcionario funcionario)
        {
            funcionario.IdFuncionario = 0;
            Contexto.Funcionarios.Add(funcionario);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = funcionario.IdFuncionario });
        }

        // PUT api/<FuncionarioController>/5
        [HttpPost]
        [Route("editar")]
        public async Task<ActionResult<Funcionario>> Alterar(Funcionario funcionario)
        {
            Contexto.Update(funcionario);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Incluir), new { id = funcionario.IdFuncionario });
        }

        // DELETE api/<FuncionarioController>/5
        [HttpDelete("remover/{id}")]
        public void Remover(Funcionario funcionario)
        {
            Contexto.Funcionarios.Remove(funcionario);
            Contexto.SaveChanges();
        }
    }
}

