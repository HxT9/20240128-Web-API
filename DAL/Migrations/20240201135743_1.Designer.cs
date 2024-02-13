﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240201135743_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("DAL.Entities.EArticolo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descrizione")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Articolo");
                });

            modelBuilder.Entity("DAL.Entities.EDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataDocumento")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("DAL.Entities.ERigaDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArticoloId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EDocumentoId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Prezzo")
                        .HasColumnType("REAL");

                    b.Property<double>("Quantita")
                        .HasColumnType("REAL");

                    b.Property<int>("TipoMovimento")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ArticoloId");

                    b.HasIndex("EDocumentoId");

                    b.ToTable("RigaDocumento");
                });

            modelBuilder.Entity("DAL.Entities.ERigaDocumento", b =>
                {
                    b.HasOne("DAL.Entities.EArticolo", "Articolo")
                        .WithMany()
                        .HasForeignKey("ArticoloId");

                    b.HasOne("DAL.Entities.EDocumento", null)
                        .WithMany("Righe")
                        .HasForeignKey("EDocumentoId");

                    b.Navigation("Articolo");
                });

            modelBuilder.Entity("DAL.Entities.EDocumento", b =>
                {
                    b.Navigation("Righe");
                });
#pragma warning restore 612, 618
        }
    }
}