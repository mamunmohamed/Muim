﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Muim.Domain.Context;

namespace Muim.Domain.Migrations
{
    [DbContext(typeof(ContextoDb))]
    partial class ContextoDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("ClassCharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CapacidadId");

                    b.HasIndex("ClassCharacterId");

                    b.ToTable("Capacidades");
                });

            modelBuilder.Entity("Muim.Domain.Models.ClassCharacter", b =>
                {
                    b.Property<int>("ClassCharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassCharacterId");

                    b.ToTable("ClassCharacter");
                });

            modelBuilder.Entity("Muim.Domain.Models.ClassCharacterCpacidades", b =>
                {
                    b.Property<int>("CapacidadId")
                        .HasColumnType("int");

                    b.Property<int>("ClassCharacterId")
                        .HasColumnType("int");

                    b.HasKey("CapacidadId", "ClassCharacterId");

                    b.HasIndex("ClassCharacterId");

                    b.ToTable("ClassCharacterCpacidades");
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

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MagiaId");

                    b.ToTable("Magias");
                });

            modelBuilder.Entity("Muim.Domain.Models.MagiaPersonajes", b =>
                {
                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<int>("MagiaId")
                        .HasColumnType("int");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.HasKey("PersonajeId", "MagiaId");

                    b.HasIndex("MagiaId");

                    b.ToTable("MagiaPersonajes");
                });

            modelBuilder.Entity("Muim.Domain.Models.PUP", b =>
                {
                    b.Property<int>("PartidaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PartidaId", "PersonajeId", "UserId");

                    b.HasIndex("PersonajeId");

                    b.HasIndex("UserId");

                    b.ToTable("Pup");
                });

            modelBuilder.Entity("Muim.Domain.Models.Partida", b =>
                {
                    b.Property<int>("PartidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartidaId");

                    b.ToTable("Partidas");
                });

            modelBuilder.Entity("Muim.Domain.Models.PartidaUsuario", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("PartidaId")
                        .HasColumnType("int");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.HasKey("UserId", "PartidaId");

                    b.HasIndex("PartidaId");

                    b.ToTable("PartidaUsuario");
                });

            modelBuilder.Entity("Muim.Domain.Models.Personaje", b =>
                {
                    b.Property<int>("PersonajeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgilidadEntrenado")
                        .HasColumnType("int");

                    b.Property<int>("AgilidadPuntos")
                        .HasColumnType("int");

                    b.Property<int>("Aspecto")
                        .HasColumnType("int");

                    b.Property<int>("BaseDeKan")
                        .HasColumnType("int");

                    b.Property<int?>("ClassCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Constitución")
                        .HasColumnType("int");

                    b.Property<int>("DestrezaEntrenado")
                        .HasColumnType("int");

                    b.Property<int>("DestrezaPuntos")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("EscudoMásico")
                        .HasColumnType("int");

                    b.Property<int>("EsperanzaEntrenado")
                        .HasColumnType("int");

                    b.Property<int>("EsperanzaPuntos")
                        .HasColumnType("int");

                    b.Property<string>("EstadoFisico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoMental")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fortuna")
                        .HasColumnType("int");

                    b.Property<string>("HerenciMaagica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<int>("PoderEntrenado")
                        .HasColumnType("int");

                    b.Property<int>("PoderMagico")
                        .HasColumnType("int");

                    b.Property<int>("PoderPuntos")
                        .HasColumnType("int");

                    b.Property<int>("Potencial")
                        .HasColumnType("int");

                    b.Property<int>("PuntosARepartir")
                        .HasColumnType("int");

                    b.Property<int>("SabiduríaEntrenado")
                        .HasColumnType("int");

                    b.Property<int>("SabiduríaPuntos")
                        .HasColumnType("int");

                    b.Property<int>("Tamaño")
                        .HasColumnType("int");

                    b.Property<int>("TierDeArmadura")
                        .HasColumnType("int");

                    b.Property<int?>("TipoId")
                        .HasColumnType("int");

                    b.Property<int>("ValorEntrenado")
                        .HasColumnType("int");

                    b.Property<int>("ValorPuntos")
                        .HasColumnType("int");

                    b.HasKey("PersonajeId");

                    b.HasIndex("ClassCharacterId");

                    b.HasIndex("TipoId")
                        .IsUnique()
                        .HasFilter("[TipoId] IS NOT NULL");

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

                    b.Property<int>("Nivel")
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

                    b.Property<int>("Nivel")
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

                    b.Property<int>("Nivel")
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

            modelBuilder.Entity("Muim.Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Muim.Domain.Models.Capacidad", b =>
                {
                    b.HasOne("Muim.Domain.Models.ClassCharacter", null)
                        .WithMany("Capacidades")
                        .HasForeignKey("ClassCharacterId");
                });

            modelBuilder.Entity("Muim.Domain.Models.ClassCharacterCpacidades", b =>
                {
                    b.HasOne("Muim.Domain.Models.Capacidad", "Capacidad")
                        .WithMany()
                        .HasForeignKey("CapacidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muim.Domain.Models.ClassCharacter", "ClassCharacter")
                        .WithMany()
                        .HasForeignKey("ClassCharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.Equipo", b =>
                {
                    b.HasOne("Muim.Domain.Models.Personaje", "Personaje")
                        .WithMany("Equipos")
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.MagiaPersonajes", b =>
                {
                    b.HasOne("Muim.Domain.Models.Magia", "Magia")
                        .WithMany()
                        .HasForeignKey("MagiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muim.Domain.Models.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.PUP", b =>
                {
                    b.HasOne("Muim.Domain.Models.Partida", "Partida")
                        .WithMany()
                        .HasForeignKey("PartidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muim.Domain.Models.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muim.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.PartidaUsuario", b =>
                {
                    b.HasOne("Muim.Domain.Models.Partida", "Partida")
                        .WithMany()
                        .HasForeignKey("PartidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Muim.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Muim.Domain.Models.Personaje", b =>
                {
                    b.HasOne("Muim.Domain.Models.ClassCharacter", "classCharacter")
                        .WithMany()
                        .HasForeignKey("ClassCharacterId");

                    b.HasOne("Muim.Domain.Models.Tipo", "Tipo")
                        .WithOne("Personaje")
                        .HasForeignKey("Muim.Domain.Models.Personaje", "TipoId");
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
                        .WithMany()
                        .HasForeignKey("RazaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
