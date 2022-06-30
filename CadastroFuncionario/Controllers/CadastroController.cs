using CadastroFuncionario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFuncionario.Controllers
{
    //sempre fica fora da classe
    [ApiController]
    [Route("[controller]")]

    public class CadastroController : ControllerBase
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();
        private static int id { get; set; }

        [HttpPost]
        public void AdicionarFuncionario([FromBody] Funcionario funcionario)
        {
            funcionario.Id = id++;
            funcionarios.Add(funcionario); 
        }

        [HttpGet]
        public IEnumerable<Funcionario> RecuperaFuncionario()
        {
            return funcionarios;
        }
    }
}
