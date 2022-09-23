﻿// <auto-generated />
using System;
using Cotacao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cotacao.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Cotacao.Models.Entities.BTCBRL", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ask")
                        .HasColumnType("longtext")
                        .HasColumnName("Venda");

                    b.Property<string>("bid")
                        .HasColumnType("longtext")
                        .HasColumnName("Compra");

                    b.Property<string>("code")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter de");

                    b.Property<string>("codein")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter para");

                    b.Property<string>("create_date")
                        .HasColumnType("longtext")
                        .HasColumnName("Data/Hora");

                    b.Property<string>("high")
                        .HasColumnType("longtext")
                        .HasColumnName("Alta da moeda");

                    b.Property<string>("low")
                        .HasColumnType("longtext")
                        .HasColumnName("Baixa da Moeda");

                    b.Property<string>("name")
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao da convercao");

                    b.Property<string>("pctChange")
                        .HasColumnType("longtext")
                        .HasColumnName("Porcetagem de variação");

                    b.Property<string>("timestamp")
                        .HasColumnType("longtext")
                        .HasColumnName("Carimbo de data/hora");

                    b.Property<string>("varBid")
                        .HasColumnType("longtext")
                        .HasColumnName("Variação da moeda");

                    b.HasKey("Id");

                    b.ToTable("BTCBRL");
                });

            modelBuilder.Entity("Cotacao.Models.Entities.EURBRL", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ask")
                        .HasColumnType("longtext")
                        .HasColumnName("Venda");

                    b.Property<string>("bid")
                        .HasColumnType("longtext")
                        .HasColumnName("Compra");

                    b.Property<string>("code")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter de");

                    b.Property<string>("codein")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter para");

                    b.Property<string>("create_date")
                        .HasColumnType("longtext")
                        .HasColumnName("Data/Hora");

                    b.Property<string>("high")
                        .HasColumnType("longtext")
                        .HasColumnName("Alta da moeda");

                    b.Property<string>("low")
                        .HasColumnType("longtext")
                        .HasColumnName("Baixa da Moeda");

                    b.Property<string>("name")
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao da convercao");

                    b.Property<string>("pctChange")
                        .HasColumnType("longtext")
                        .HasColumnName("Porcetagem de variação");

                    b.Property<string>("timestamp")
                        .HasColumnType("longtext")
                        .HasColumnName("Carimbo de data/hora");

                    b.Property<string>("varBid")
                        .HasColumnType("longtext")
                        .HasColumnName("Variação da moeda");

                    b.HasKey("Id");

                    b.ToTable("EURBRL");
                });

            modelBuilder.Entity("Cotacao.Models.Entities.MoedaGenerica", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ask")
                        .HasColumnType("longtext")
                        .HasColumnName("Venda");

                    b.Property<string>("bid")
                        .HasColumnType("longtext")
                        .HasColumnName("Compra");

                    b.Property<string>("code")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter de");

                    b.Property<string>("codein")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter para");

                    b.Property<string>("create_date")
                        .HasColumnType("longtext")
                        .HasColumnName("Data/Hora");

                    b.Property<string>("high")
                        .HasColumnType("longtext")
                        .HasColumnName("Alta da moeda");

                    b.Property<string>("low")
                        .HasColumnType("longtext")
                        .HasColumnName("Baixa da Moeda");

                    b.Property<string>("name")
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao da convercao");

                    b.Property<string>("pctChange")
                        .HasColumnType("longtext")
                        .HasColumnName("Porcetagem de variação");

                    b.Property<string>("timestamp")
                        .HasColumnType("longtext")
                        .HasColumnName("Carimbo de data/hora");

                    b.Property<string>("varBid")
                        .HasColumnType("longtext")
                        .HasColumnName("Variação da moeda");

                    b.HasKey("Id");

                    b.ToTable("MoedaGenericas");
                });

            modelBuilder.Entity("Cotacao.Models.Entities.MOEDAS", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ask")
                        .HasColumnType("longtext")
                        .HasColumnName("Venda");

                    b.Property<string>("bid")
                        .HasColumnType("longtext")
                        .HasColumnName("Compra");

                    b.Property<string>("code")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter de");

                    b.Property<string>("codein")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter para");

                    b.Property<string>("create_date")
                        .HasColumnType("longtext")
                        .HasColumnName("Data/Hora");

                    b.Property<string>("high")
                        .HasColumnType("longtext")
                        .HasColumnName("Alta da moeda");

                    b.Property<string>("low")
                        .HasColumnType("longtext")
                        .HasColumnName("Baixa da Moeda");

                    b.Property<string>("name")
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao da convercao");

                    b.Property<string>("pctChange")
                        .HasColumnType("longtext")
                        .HasColumnName("Porcetagem de variação");

                    b.Property<string>("timestamp")
                        .HasColumnType("longtext")
                        .HasColumnName("Carimbo de data/hora");

                    b.Property<string>("varBid")
                        .HasColumnType("longtext")
                        .HasColumnName("Variação da moeda");

                    b.HasKey("Id");

                    b.ToTable("MOEDAS");
                });

            modelBuilder.Entity("Cotacao.Models.Entities.Root", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BTCBRLId")
                        .HasColumnType("int");

                    b.Property<int?>("EURBRLId")
                        .HasColumnType("int");

                    b.Property<int?>("MOEDASId")
                        .HasColumnType("int");

                    b.Property<int?>("MoedaGenericasId")
                        .HasColumnType("int");

                    b.Property<int?>("RUBBRLId")
                        .HasColumnType("int");

                    b.Property<int?>("USDBRLId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BTCBRLId");

                    b.HasIndex("EURBRLId");

                    b.HasIndex("MOEDASId");

                    b.HasIndex("MoedaGenericasId");

                    b.HasIndex("RUBBRLId");

                    b.HasIndex("USDBRLId");

                    b.ToTable("Roots");
                });

            modelBuilder.Entity("Cotacao.Models.Entities.RUBBRL", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ask")
                        .HasColumnType("longtext")
                        .HasColumnName("Venda");

                    b.Property<string>("bid")
                        .HasColumnType("longtext")
                        .HasColumnName("Compra");

                    b.Property<string>("code")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter de");

                    b.Property<string>("codein")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter para");

                    b.Property<string>("create_date")
                        .HasColumnType("longtext")
                        .HasColumnName("Data/Hora");

                    b.Property<string>("high")
                        .HasColumnType("longtext")
                        .HasColumnName("Alta da moeda");

                    b.Property<string>("low")
                        .HasColumnType("longtext")
                        .HasColumnName("Baixa da Moeda");

                    b.Property<string>("name")
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao da convercao");

                    b.Property<string>("pctChange")
                        .HasColumnType("longtext")
                        .HasColumnName("Porcetagem de variação");

                    b.Property<string>("timestamp")
                        .HasColumnType("longtext")
                        .HasColumnName("Carimbo de data/hora");

                    b.Property<string>("varBid")
                        .HasColumnType("longtext")
                        .HasColumnName("Variação da moeda");

                    b.HasKey("Id");

                    b.ToTable("RUBBRL");
                });

            modelBuilder.Entity("Cotacao.Models.Entities.USDBRL", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ask")
                        .HasColumnType("longtext")
                        .HasColumnName("Venda");

                    b.Property<string>("bid")
                        .HasColumnType("longtext")
                        .HasColumnName("Compra");

                    b.Property<string>("code")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter de");

                    b.Property<string>("codein")
                        .HasColumnType("longtext")
                        .HasColumnName("Converter para");

                    b.Property<string>("create_date")
                        .HasColumnType("longtext")
                        .HasColumnName("Data/Hora");

                    b.Property<string>("high")
                        .HasColumnType("longtext")
                        .HasColumnName("Alta da moeda");

                    b.Property<string>("low")
                        .HasColumnType("longtext")
                        .HasColumnName("Baixa da Moeda");

                    b.Property<string>("name")
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao da convercao");

                    b.Property<string>("pctChange")
                        .HasColumnType("longtext")
                        .HasColumnName("Porcetagem de variação");

                    b.Property<string>("timestamp")
                        .HasColumnType("longtext")
                        .HasColumnName("Carimbo de data/hora");

                    b.Property<string>("varBid")
                        .HasColumnType("longtext")
                        .HasColumnName("Variação da moeda");

                    b.HasKey("Id");

                    b.ToTable("USDBRL");
                });

            modelBuilder.Entity("Cotacao.Models.Entities.Root", b =>
                {
                    b.HasOne("Cotacao.Models.Entities.BTCBRL", "BTCBRL")
                        .WithMany()
                        .HasForeignKey("BTCBRLId");

                    b.HasOne("Cotacao.Models.Entities.EURBRL", "EURBRL")
                        .WithMany()
                        .HasForeignKey("EURBRLId");

                    b.HasOne("Cotacao.Models.Entities.MOEDAS", "MOEDAS")
                        .WithMany()
                        .HasForeignKey("MOEDASId");

                    b.HasOne("Cotacao.Models.Entities.MoedaGenerica", "MoedaGenericas")
                        .WithMany()
                        .HasForeignKey("MoedaGenericasId");

                    b.HasOne("Cotacao.Models.Entities.RUBBRL", "RUBBRL")
                        .WithMany()
                        .HasForeignKey("RUBBRLId");

                    b.HasOne("Cotacao.Models.Entities.USDBRL", "USDBRL")
                        .WithMany()
                        .HasForeignKey("USDBRLId");

                    b.Navigation("BTCBRL");

                    b.Navigation("EURBRL");

                    b.Navigation("MOEDAS");

                    b.Navigation("MoedaGenericas");

                    b.Navigation("RUBBRL");

                    b.Navigation("USDBRL");
                });
#pragma warning restore 612, 618
        }
    }
}
