using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroFuncionario.Migrations
{
    public partial class AjusteDataTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Funcionarios");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Funcionarios",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Funcionarios");

            migrationBuilder.AddColumn<string>(
                name: "DataNascimento",
                table: "Funcionarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
