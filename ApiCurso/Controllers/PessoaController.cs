using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCurso.Model;
using ApiCurso.Servicos.Implementacao;
using Microsoft.AspNetCore.Mvc;

namespace ApiCurso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private IPessoaServico _pessoaServico;

        public PessoaController (IPessoaServico pessoaServico)
        {
            _pessoaServico = pessoaServico;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_pessoaServico.Procurar());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var pessoa = _pessoaServico.ProcurarPorId(id);
            if (pessoa == null) return NotFound();
            return Ok(pessoa);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Pessoa pessoa)
        {
            if (pessoa == null) return BadRequest();
            return new ObjectResult(_pessoaServico.Criar(pessoa));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Pessoa pessoa)
        {
            if (pessoa == null) return BadRequest();
            return new ObjectResult(_pessoaServico.Atualizar(pessoa));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pessoaServico.Apagar(id);
            return NoContent();
        }
    }
}
