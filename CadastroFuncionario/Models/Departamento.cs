using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CadastroFuncionario.Models;

public class Departamento
{
    public Departamento()
    {
        Funcionarios = new Collection<Funcionario>();
    }
 
    public int DepartamentoId { get; set; }
    [Required]
    [MaxLength(80)]
    public string? NomeDepartamento { get; set; }
    [JsonIgnore]
    public ICollection<Funcionario> Funcionarios { get; set; }
}
