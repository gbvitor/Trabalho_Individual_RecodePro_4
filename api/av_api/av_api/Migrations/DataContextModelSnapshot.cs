﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using av_api.Context;

#nullable disable

namespace av_api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("av_api.Models.CadastroViagem", b =>
                {
                    b.Property<int>("idCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("clientesidCliente")
                        .HasColumnType("int");

                    b.Property<int?>("destinosIdDestino")
                        .HasColumnType("int");

                    b.HasKey("idCadastro");

                    b.HasIndex("clientesidCliente");

                    b.HasIndex("destinosIdDestino");

                    b.ToTable("CadastroViagem");
                });

            modelBuilder.Entity("av_api.Models.Clientes", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("av_api.Models.Destinos", b =>
                {
                    b.Property<int>("IdDestino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cepDestino")
                        .HasColumnType("longtext");

                    b.Property<string>("nomeDestino")
                        .HasColumnType("longtext");

                    b.Property<double>("valorPassagem")
                        .HasColumnType("double");

                    b.HasKey("IdDestino");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("av_api.Models.CadastroViagem", b =>
                {
                    b.HasOne("av_api.Models.Clientes", "clientes")
                        .WithMany()
                        .HasForeignKey("clientesidCliente");

                    b.HasOne("av_api.Models.Destinos", "destinos")
                        .WithMany()
                        .HasForeignKey("destinosIdDestino");

                    b.Navigation("clientes");

                    b.Navigation("destinos");
                });
#pragma warning restore 612, 618
        }
    }
}