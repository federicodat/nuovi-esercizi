﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using REST_EF_06_Migrazioni.Context;

#nullable disable

namespace REST_EF_O6_Migrazioni.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20241015082504_Iniziale")]
    partial class Iniziale
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("REST_EF_06_Migrazioni.Models.Film", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmID"));

                    b.Property<int>("Anno")
                        .HasColumnType("int");

                    b.Property<string>("Autore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descrizione")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("FilmID");

                    b.ToTable("Proiezioni");
                });
#pragma warning restore 612, 618
        }
    }
}