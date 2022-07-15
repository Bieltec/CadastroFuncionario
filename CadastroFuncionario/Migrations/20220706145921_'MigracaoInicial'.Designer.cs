﻿// <auto-generated />
using CadastroFuncionario.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroFuncionario.Migrations
{
    [DbContext(typeof(CadastroDbContext))]
    [Migration("20220706145921_'MigracaoInicial'")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CadastroFuncionario.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desenvolvimento")
                        .HasColumnType("longtext");

                    b.Property<string>("Financeiro")
                        .HasColumnType("longtext");

                    b.Property<string>("Gestor")
                        .HasColumnType("longtext");

                    b.Property<string>("Suporte")
                        .HasColumnType("longtext");

                    b.Property<string>("TI")
                        .HasColumnType("longtext");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("CadastroFuncionario.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contato")
                        .HasColumnType("longtext");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("longtext");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Genero")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("CadastroFuncionario.Models.Funcionario", b =>
                {
                    b.HasOne("CadastroFuncionario.Models.Departamento", "Depertamento")
                        .WithMany("Funcionarios")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depertamento");
                });

            modelBuilder.Entity("CadastroFuncionario.Models.Departamento", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
