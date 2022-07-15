using CadastroFuncionario.Context;
using CadastroFuncionario.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroFuncionario.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly CadastroDbContext _context;

        public FuncionarioController(CadastroDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Funcionario>> Get()
        {
            var funcionario = _context.Funcionarios.ToList();
            if (funcionario is null)
            {
                return NotFound("Funcionário não encontrado...");
            }
            return funcionario;
        }
        [HttpGet("{id:int}", Name = "ObterFuncionario")]
        public ActionResult<Funcionario> Get(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(x => x.FuncionarioId == id);

            if (funcionario is null)
            {
                return NotFound("Funcionário não encontrado");
            }
            return Ok(funcionario);
        }
        [HttpPost]
        public ActionResult Post(Funcionario funcionario)
        {
            if (funcionario is null)
            {
                return BadRequest();
            }
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterFuncionario", new { id = funcionario.FuncionarioId }, funcionario);
        }
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Funcionario funcionario)
        {
            if (id != funcionario.FuncionarioId)
            {
                return BadRequest();
            }
            _context.Entry(funcionario).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(funcionario);
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var funcionarios = _context.Funcionarios.FirstOrDefault(x => x.FuncionarioId == id);
            if (funcionarios is null)
            {
                return NotFound("Funcionário não encontrado");
            }
            _context.Funcionarios.Remove(funcionarios);
            _context.SaveChanges();
            return Ok(funcionarios);
        }
    }
}
