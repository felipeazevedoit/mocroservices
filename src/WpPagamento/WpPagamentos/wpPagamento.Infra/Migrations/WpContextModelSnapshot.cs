﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wpPagamento.Infra;

namespace wpPagamento.Infra.Migrations
{
    [DbContext(typeof(WpContext))]
    partial class WpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WpPagamentos.Entidade.Loja", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioCriacao")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioEdicao")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataEdicao")
                        .HasColumnType("datetime2");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<string>("idPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("propiedadesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("propiedadesID");

                    b.ToTable("loja");
                });

            modelBuilder.Entity("WpPagamentos.Entidade.Propriedades", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Meio")
                        .HasColumnType("bit");

                    b.Property<int>("Moeda")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parcela")
                        .HasColumnType("int");

                    b.Property<bool>("Recalculo")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioCriacao")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioEdicao")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.Property<DateTime>("dataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataEdicao")
                        .HasColumnType("datetime2");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<string>("tidErede")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Propiedade");
                });

            modelBuilder.Entity("WpPagamentos.Entidade.Loja", b =>
                {
                    b.HasOne("WpPagamentos.Entidade.Propriedades", "propiedades")
                        .WithMany()
                        .HasForeignKey("propiedadesID");
                });
#pragma warning restore 612, 618
        }
    }
}
