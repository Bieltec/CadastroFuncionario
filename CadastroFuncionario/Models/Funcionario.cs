namespace CadastroFuncionario.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Genero { get; set; }
        // passar propriedade com datetype, aprender. 
        public string DataNascimento { get; set; }
        public string Email { get; set; }
      
    }
}
