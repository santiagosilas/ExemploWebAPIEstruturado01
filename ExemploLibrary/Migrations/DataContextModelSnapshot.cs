﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ExemploLibrary.Contextos;

namespace ExemploLibrary.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExemploWebApi.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Contato", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Empregado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Empregados");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Etiqueta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Gerente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Gerentes");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.ProdutoEtiqueta", b =>
                {
                    b.Property<int>("ProdutoId");

                    b.Property<int>("EtiquetaId");

                    b.HasKey("ProdutoId", "EtiquetaId");

                    b.HasIndex("EtiquetaId");

                    b.ToTable("ProdutosEtiquetas");
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Cliente", b =>
                {
                    b.HasOne("ExemploWebApi.Entidades.Pessoa", "Pessoa")
                        .WithOne("Cliente")
                        .HasForeignKey("ExemploWebApi.Entidades.Cliente", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Empregado", b =>
                {
                    b.HasOne("ExemploWebApi.Entidades.Pessoa", "Pessoa")
                        .WithOne("Empregado")
                        .HasForeignKey("ExemploWebApi.Entidades.Empregado", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Gerente", b =>
                {
                    b.HasOne("ExemploWebApi.Entidades.Pessoa", "Pessoa")
                        .WithOne("Gerente")
                        .HasForeignKey("ExemploWebApi.Entidades.Gerente", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.Produto", b =>
                {
                    b.HasOne("ExemploWebApi.Entidades.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploWebApi.Entidades.ProdutoEtiqueta", b =>
                {
                    b.HasOne("ExemploWebApi.Entidades.Etiqueta", "Etiqueta")
                        .WithMany("ProdutoEtiqueta")
                        .HasForeignKey("EtiquetaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploWebApi.Entidades.Produto", "Produto")
                        .WithMany("ProdutosEtiquetas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
