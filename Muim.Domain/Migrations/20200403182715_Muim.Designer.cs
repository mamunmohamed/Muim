﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Muim.Domain.Context;

namespace Muim.Domain.Migrations
{
    [DbContext(typeof(ContextoDb))]
    [Migration("20200403182715_Muim")]
    partial class Muim
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Muim.Domain.Models.Capacidad", b =>
                {
                    b.Property<int>("CapacidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("CapacidadId");

                    b.HasIndex("TipoId");

                    b.ToTable("Canciones");
                });

            modelBuilder.Entity("Muim.Domain.Models.Equipo", b =>
                {
                    b.Property<int>("EquipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<int>("Tier")
                        .HasColumnType("int");

                    b.HasKey("EquipoId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Muim.Domain.Models.HabilidadActiva", b =>
                {
                    b.Property<int>("HabilidadActivaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HabilidadActivaId");

                    b.ToTable("HabilidadActivas");
                });

            modelBuilder.Entity("Muim.Domain.Models.HabilidadPasiva", b =>
                {
                    b.Property<int>("HabilidadPasivaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HabilidadPasivaId");

                    b.ToTable("HabilidadPasivas");
                });

            modelBuilder.Entity("Muim.Domain.Models.Magia", b =>
                {
                    b.Property<int>("MagiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MagiaId");

                    b.ToTable("Magias");
                });

            modelBuilder.Entity("Muim.Domain.Models.Personaje", b =>
                {
                    b.Property<int>("PersonajeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int?>("MagiaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RazaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("PersonajeId");

                    b.HasIndex("MagiaId");

                    b.HasIndex("RazaId");

                    b.HasIndex("TipoId");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("Muim.Domain.Models.PersonajeHabilidadActiva", b =>
                {
                    b.Property<int>("HabilidadActivaInt")
                        .HasColumnType("int");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<int?>("HabilidadActivaId")
                        .HasColumnType("int");

                    b.HasKey("HabilidadActivaInt", "PersonajeId");

                    b.HasIndex("HabilidadActivaId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("PersonajeHabilidadActiva");
                });

            modelBuilder.Entity("Muim.Domain.Models.PersonajeHabilidadPasivas", b =>
                {
                    b.Property<int>("HabilidadPasivaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.HasKey("HabilidadPasivaId", "PersonajeId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("PersonajeHabilidadPasivas");
                });

            modelBuilder.Entity("Muim.Domain.Models.PersonajesCapacidades", b =>
                {
                    b.Property<int>("CapacidadId")
                        .HasColumnType("int");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.HasKey("CapacidadId", "PersonajeId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("PersonajesCapacidades");
                });

            modelBuilder.Entity("Muim.Domain.Models.Raza", b =>
                {
                    b.Property<int>("RazaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RazaId");

                    b.ToTable("Razas");
                });

            modelBuilder.Entity("Muim.Domain.Models.Tipo", b =>
                {
                    b.Property<int>("TipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RazaId")
                        .HasColumnType("int");

                    b.HasKey("TipoId");

                    b.HasIndex("RazaId");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("Muim.Domain.Models.Capacidad", b =>
                {
                    b.HasOne("Muim.Domain.Models.Tipo", null)
                        .WithMany("Capacidades")
                        .HasForeignKey("TipoId");
                });

            modelBuilder.Entity("Muim.Domain.Models.Equipo", b =>
                {
                    b.HasOne("Muim.Domain.Models.Personaje", "Personaje")
                        .WithMany("Equipos")
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.Personaje", b =>
                {
                    b.HasOne("Muim.Domain.Models.Magia", null)
                        .WithMany("Personajes")
                        .HasForeignKey("MagiaId");

                    b.HasOne("Muim.Domain.Models.Raza", "Raza")
                        .WithMany()
                        .HasForeignKey("RazaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muim.Domain.Models.Tipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.PersonajeHabilidadActiva", b =>
                {
                    b.HasOne("Muim.Domain.Models.HabilidadActiva", "habilidadActiva")
                        .WithMany()
                        .HasForeignKey("HabilidadActivaId");

                    b.HasOne("Muim.Domain.Models.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.PersonajeHabilidadPasivas", b =>
                {
                    b.HasOne("Muim.Domain.Models.HabilidadPasiva", "habilidadPasiva")
                        .WithMany()
                        .HasForeignKey("HabilidadPasivaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muim.Domain.Models.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.PersonajesCapacidades", b =>
                {
                    b.HasOne("Muim.Domain.Models.Capacidad", "Capacidad")
                        .WithMany()
                        .HasForeignKey("CapacidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muim.Domain.Models.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.Tipo", b =>
                {
                    b.HasOne("Muim.Domain.Models.Raza", "Raza")
                        .WithMany("Tipos")
                        .HasForeignKey("RazaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
