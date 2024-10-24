using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace rest_02_ef_libreria.Models;

public partial class AEfLez02LibreriaContext : DbContext
{
    public AEfLez02LibreriaContext()
    {
    }

    public AEfLez02LibreriaContext(DbContextOptions<AEfLez02LibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DATTILO-PC\\SQLEXPRESS;Database=a_ef_lez02_libreria;User Id=accademy;Password=fedeaccademy;\nMultipleActiveResultSets=true;\nEncrypt=false;\nTrustServerCertificate=false\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.LibroId).HasName("PK__Libro__18C65F4B7AD74561");

            entity.ToTable("Libro");

            entity.Property(e => e.LibroId).HasColumnName("libroID");
            entity.Property(e => e.Autore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("autore");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Descrizione)
                .HasColumnType("text")
                .HasColumnName("descrizione");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("prezzo");
            entity.Property(e => e.Quantita)
                .HasDefaultValue(1)
                .HasColumnName("quantita");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
