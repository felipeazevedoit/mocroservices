﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpPacientes.Infrastructure;

namespace WpPacientes.Infrastructure.Migrations
{
    [DbContext(typeof(WpPacientesContext))]
    [Migration("20190108170731_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WpPacientes.Entities.Paciente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Altura");

                    b.Property<bool>("Ativo");

                    b.Property<string>("CPF");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataEdicao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("IdCliente");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Peso");

                    b.Property<string>("Sexo");

                    b.Property<string>("SobreNome");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioCriacao");

                    b.Property<int>("UsuarioEdicao");

                    b.HasKey("ID");

                    b.ToTable("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}