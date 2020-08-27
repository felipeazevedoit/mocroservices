﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpNoticias.Infrastructure;

namespace WpNoticias.Infrastructure.Migrations
{
    [DbContext(typeof(WpNoticiasContext))]
    [Migration("20190215121537_Categorias")]
    partial class Categorias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WpNoticias.Entities.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataEdicao");

                    b.Property<string>("Descricao");

                    b.Property<int>("IdCliente");

                    b.Property<string>("Nome");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioCriacao");

                    b.Property<int>("UsuarioEdicao");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("WpNoticias.Entities.Comentario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataEdicao");

                    b.Property<string>("Descricao");

                    b.Property<int>("IdCliente");

                    b.Property<string>("Nome");

                    b.Property<int>("NoticiaId");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioCriacao");

                    b.Property<int>("UsuarioEdicao");

                    b.HasKey("ID");

                    b.HasIndex("NoticiaId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("WpNoticias.Entities.Noticia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Conteudo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataEdicao");

                    b.Property<string>("Descricao");

                    b.Property<int>("IdCliente");

                    b.Property<string>("Nome");

                    b.Property<bool>("Privado");

                    b.Property<int>("Status");

                    b.Property<string>("Tags");

                    b.Property<int>("Tipo");

                    b.Property<int>("UsuarioCriacao");

                    b.Property<int>("UsuarioEdicao");

                    b.HasKey("ID");

                    b.ToTable("Noticias");
                });

            modelBuilder.Entity("WpNoticias.Entities.Comentario", b =>
                {
                    b.HasOne("WpNoticias.Entities.Noticia", "Noticia")
                        .WithMany("Comentarios")
                        .HasForeignKey("NoticiaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
