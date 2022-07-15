using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CadastroFuncionario.Models;

public class Funcionario
{
    
    public int FuncionarioId { get; set; }
    [Required]
    [MaxLength(80)]
    public string? Nome { get; set; }
    [Required]
    [MaxLength(12)]
    public string? Contato { get; set; }
    [Required]
    [MaxLength(10)]
    public string? Genero { get; set; }
    [Required]
    [MaxLength(40)]
    public string? Email { get; set; }
    public DateTime DataCadastro { get; set; }
    public int DepartamentoId { get; set; }
    [JsonIgnore]
    public Departamento? Departamento { get; set; }

    // passar propriedade com datetype, aprender. 
}
