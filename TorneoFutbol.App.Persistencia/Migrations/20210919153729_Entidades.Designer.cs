﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210919153729_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoFutbol.App.Dominio.DesempeñoEquipos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad_Partidos_Empatados")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad_Partidos_Ganados")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad_Partidos_Jugados")
                        .HasColumnType("int");

                    b.Property<int>("GC")
                        .HasColumnType("int");

                    b.Property<int>("GF")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DesempeñoEquipos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Estadio");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Jugadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("equiposId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("equiposId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.equipos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DesempeñoEquiposId")
                        .HasColumnType("int");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DesempeñoEquiposId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("equipos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.Municipio", "Municipio")
                        .WithMany("Estadio")
                        .HasForeignKey("MunicipioId");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Jugadores", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.equipos", "equipos")
                        .WithMany("Jugadores")
                        .HasForeignKey("equiposId");

                    b.Navigation("equipos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.equipos", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.DesempeñoEquipos", "DesempeñoEquipos")
                        .WithMany()
                        .HasForeignKey("DesempeñoEquiposId");

                    b.HasOne("TorneoFutbol.App.Dominio.Municipio", "Municipio")
                        .WithMany("equipos")
                        .HasForeignKey("MunicipioId");

                    b.Navigation("DesempeñoEquipos");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Municipio", b =>
                {
                    b.Navigation("equipos");

                    b.Navigation("Estadio");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.equipos", b =>
                {
                    b.Navigation("Jugadores");
                });
#pragma warning restore 612, 618
        }
    }
}
