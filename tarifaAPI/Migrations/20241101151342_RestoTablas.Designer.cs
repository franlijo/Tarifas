﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tarifaAPI.Data;

#nullable disable

namespace tarifaAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241101151342_RestoTablas")]
    partial class RestoTablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tarifaAPI.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("empresas", (string)null);
                });

            modelBuilder.Entity("tarifaAPI.Models.EmpresaImporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<float>("Importe")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("empresaImportes", (string)null);
                });

            modelBuilder.Entity("tarifaAPI.Models.EmpresaServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("importe")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("empresaServicios", (string)null);
                });

            modelBuilder.Entity("tarifaAPI.Models.EmpresaTrabajadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTrabajdores")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("empresaTrabajadores", (string)null);
                });

            modelBuilder.Entity("tarifaAPI.Models.Tarifa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DesdeFecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesdeTrabajadores")
                        .HasColumnType("int");

                    b.Property<DateTime>("HastaFecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("HastaTrabajadores")
                        .HasColumnType("int");

                    b.Property<float>("ImporteTrabajador")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("tarifas", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
