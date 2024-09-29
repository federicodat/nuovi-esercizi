using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Esercizio_gestione_libreria.Models;

public partial class EsercizioGestioneLibreriaContext : DbContext
{
    public EsercizioGestioneLibreriaContext()
    {
    }

    public EsercizioGestioneLibreriaContext(DbContextOptions<EsercizioGestioneLibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libri> Libris { get; set; }

    public virtual DbSet<Prestiti> Prestitis { get; set; }

    public virtual DbSet<Utenti> Utentis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DATTILO-PC\\SQLEXPRESS;Database=Esercizio_gestione_libreria;User Id=accademy;Password=fedeaccademy;\nMultipleActiveResultSets=true;\nEncrypt=false;\nTrustServerCertificate=false\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libri>(entity =>
        {
            entity.HasKey(e => e.LibroId).HasName("PK__Libri__35A1EC8D0B487760");

            entity.ToTable("Libri");

            entity.Property(e => e.LibroId).HasColumnName("LibroID");
            entity.Property(e => e.Anno)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("anno");
            entity.Property(e => e.Disponibilita).HasColumnName("disponibilita");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        modelBuilder.Entity<Prestiti>(entity =>
        {
            entity.HasKey(e => e.PrestitoId).HasName("PK__Prestiti__7E579A75F99197EE");

            entity.ToTable("Prestiti");

            entity.Property(e => e.PrestitoId).HasColumnName("prestitoID");
            entity.Property(e => e.DataPrestito).HasColumnName("Data_prestito");
            entity.Property(e => e.DataRitorno).HasColumnName("Data_RITORNO");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.LibroRif).HasColumnName("LibroRIF");
            entity.Property(e => e.UtenteRif).HasColumnName("UtenteRIF");

            entity.HasOne(d => d.LibroRifNavigation).WithMany(p => p.Prestitis)
                .HasForeignKey(d => d.LibroRif)
                .HasConstraintName("FK__Prestiti__LibroR__66603565");

            entity.HasOne(d => d.UtenteRifNavigation).WithMany(p => p.Prestitis)
                .HasForeignKey(d => d.UtenteRif)
                .HasConstraintName("FK__Prestiti__Utente__656C112C");
        });

        modelBuilder.Entity<Utenti>(entity =>
        {
            entity.HasKey(e => e.UtenteId).HasName("PK__Utenti__489EA72A13F3D796");

            entity.ToTable("Utenti");

            entity.Property(e => e.UtenteId).HasColumnName("UtenteID");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
