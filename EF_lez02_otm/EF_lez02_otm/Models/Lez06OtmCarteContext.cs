using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_lez02_otm.Models;

public partial class Lez06OtmCarteContext : DbContext
{
    public Lez06OtmCarteContext()
    {
    }

    public Lez06OtmCarteContext(DbContextOptions<Lez06OtmCarteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cartum> Carta { get; set; }

    public virtual DbSet<Esame> Esames { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Studente> Studentes { get; set; }

    public virtual DbSet<StudenteEsame> StudenteEsames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DATTILO-PC\\SQLEXPRESS;Database=lez06_otm_carte;User Id=accademy;Password=fedeaccademy;\nMultipleActiveResultSets=true;\nEncrypt=false;\nTrustServerCertificate=false\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cartum>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Codice, "UQ__Carta__40F9C18B4CCE58D2").IsUnique();

            entity.Property(e => e.CartaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("cartaID");
            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Negozio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("negozio");
            entity.Property(e => e.PersonaRif).HasColumnName("personaRIF");

            entity.HasOne(d => d.PersonaRifNavigation).WithMany()
                .HasForeignKey(d => d.PersonaRif)
                .HasConstraintName("FK__Carta__personaRI__59063A47");
        });

        modelBuilder.Entity<Esame>(entity =>
        {
            entity.HasKey(e => e.EsameId).HasName("PK__Esame__C5EF3E0924D662B5");

            entity.ToTable("Esame");

            entity.Property(e => e.EsameId).HasColumnName("esameID");
            entity.Property(e => e.Crediti).HasColumnName("crediti");
            entity.Property(e => e.DataEsame)
                .HasColumnType("datetime")
                .HasColumnName("data_esame");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PersonaId).HasName("PK__Persona__54B758F5C9AA6886");

            entity.ToTable("Persona");

            entity.Property(e => e.PersonaId).HasColumnName("personaID");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Studente>(entity =>
        {
            entity.HasKey(e => e.StudenteId).HasName("PK__Studente__20A4EC9144954252");

            entity.ToTable("Studente");

            entity.HasIndex(e => e.Matricola, "UQ__Studente__2C2751BAB3744E30").IsUnique();

            entity.Property(e => e.StudenteId).HasColumnName("studenteID");
            entity.Property(e => e.Matricola)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("matricola");
            entity.Property(e => e.Nominativo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nominativo");
        });

        modelBuilder.Entity<StudenteEsame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Studente_Esame");

            entity.HasIndex(e => new { e.StudenteRif, e.EsameRif }, "UQ__Studente__C715ED0A4FFFF651").IsUnique();

            entity.Property(e => e.EsameRif).HasColumnName("esameRIF");
            entity.Property(e => e.StudenteRif).HasColumnName("studenteRIF");

            entity.HasOne(d => d.EsameRifNavigation).WithMany()
                .HasForeignKey(d => d.EsameRif)
                .HasConstraintName("FK__Studente___esame__68487DD7");

            entity.HasOne(d => d.StudenteRifNavigation).WithMany()
                .HasForeignKey(d => d.StudenteRif)
                .HasConstraintName("FK__Studente___stude__6754599E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
