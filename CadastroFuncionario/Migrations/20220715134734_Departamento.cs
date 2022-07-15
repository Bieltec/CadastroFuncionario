using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroFuncionario.Migrations
{
    public partial class Departamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desenvolvimento",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "Financeiro",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "Gestor",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "Suporte",
                table: "Departamentos");

            migrationBuilder.RenameColumn(
                name: "TI",
                table: "Departamentos",
                newName: "NomeDepartamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeDepartamento",
                table: "Departamentos",
                newName: "TI");

            migrationBuilder.AddColumn<string>(
                name: "Desenvolvimento",
                table: "Departamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Financeiro",
                table: "Departamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Gestor",
                table: "Departamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Suporte",
                table: "Departamentos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
