﻿// <auto-generated />
using Identidades_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Identidades_API.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Identidades_API.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NroIdentificacion")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("varchar(17)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("SegundoNombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("TipoIdentificacion")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NroIdentificacion = "72334103",
                            PrimerApellido = "Manjarrés",
                            PrimerNombre = "Fernando",
                            SegundoApellido = "Paternina",
                            SegundoNombre = "Dario",
                            TipoIdentificacion = "CC"
                        },
                        new
                        {
                            Id = 2,
                            NroIdentificacion = "1026266986",
                            PrimerApellido = "Rodríguez",
                            PrimerNombre = "Nohora",
                            SegundoApellido = "Mora",
                            SegundoNombre = "Julieth",
                            TipoIdentificacion = "CC"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
