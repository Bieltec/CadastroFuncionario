using CadastroFuncionario.Context;
using CadastroFuncionario.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroFuncionario.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly CadastroDbContext _context;

        public DepartamentoController(CadastroDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var departamento = _context.Departamentos.ToList();
            if (departamento is null)
            {
                return NotFound("Departamento não encontrado");
            }
            return Ok(departamento);

        }
        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            var departamento = _context.Departamentos.FirstOrDefault(x => x.DepartamentoId == id);
            if (departamento is null)
            {
                return NotFound("Departamento não localizado =(");
            }
            return Ok(departamento);
        }
        [HttpPost]
        public ActionResult Post(Departamento departamento)
        {
            if (departamento is null)
            {
                return BadRequest();
            }
            _context.Departamentos.Add(departamento);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Departamento departamento)
        {
            if (id != departamento.DepartamentoId)
            {
                return BadRequest();
            }
            _context.Entry(departamento).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(departamento);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var departamento = _context.Departamentos.FirstOrDefault(x => x.DepartamentoId == id);
            if (departamento is null)
            {
                return NotFound("Departamento não localizado =(");
            }
            _context.Departamentos.Remove(departamento);
            _context.SaveChanges();
            return Ok(departamento);
        }


    }
}
