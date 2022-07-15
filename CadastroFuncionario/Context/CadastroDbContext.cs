using CadastroFuncionario.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroFuncionario.Context;

public class CadastroDbContext : DbContext
{
    public CadastroDbContext(DbContextOptions<CadastroDbContext> options) : base(options)
    {

    }

    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }

}
