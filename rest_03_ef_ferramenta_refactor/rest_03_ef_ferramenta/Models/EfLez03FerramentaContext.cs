using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace rest_03_ef_ferramenta.Models;

public partial class EfLez03FerramentaContext : DbContext
{
    public EfLez03FerramentaContext()
    {
    }

    public EfLez03FerramentaContext(DbContextOptions<EfLez03FerramentaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Prodotto> Prodottos { get; set; }

    public virtual DbSet<Reparto> Repartos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DATTILO-PC\\SQLEXPRESS;Database=ef_lez03_ferramenta;User Id=accademy;Password=fedeaccademy;\nMultipleActiveResultSets=true;\nEncrypt=false;\nTrustServerCertificate=false\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Prodotto>(entity =>
        {
            entity.HasKey(e => e.ProdottoId).HasName("PK__Prodotto__3AB659757ACA1517");

            entity.ToTable("Prodotto");

            entity.HasIndex(e => e.CodiceBarre, "UQ__Prodotto__918AE2A9076928FA").IsUnique();

            entity.Property(e => e.ProdottoId).HasColumnName("prodottoID");
            entity.Property(e => e.CodiceBarre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("codiceBarre");
            entity.Property(e => e.Descrizione)
                .HasColumnType("text")
                .HasColumnName("descrizione");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("prezzo");
            entity.Property(e => e.Quantita).HasColumnName("quantita");
            entity.Property(e => e.RepartoRif).HasColumnName("repartoRIF");

            entity.HasOne(d => d.RepartoRifNavigation).WithMany(p => p.Prodottos)
                .HasForeignKey(d => d.RepartoRif)
                .HasConstraintName("FK__Prodotto__repart__3D5E1FD2");
        });

        modelBuilder.Entity<Reparto>(entity =>
        {
            entity.HasKey(e => e.RepartoId).HasName("PK__Reparto__612C4F3651EAD523");

            entity.ToTable("Reparto");

            entity.HasIndex(e => new { e.Nome, e.Fila }, "UQ__Reparto__7C26DB9F90B6BE42").IsUnique();

            entity.HasIndex(e => e.RepartoCod, "UQ__Reparto__EF6534E5BF27804F").IsUnique();

            entity.Property(e => e.RepartoId).HasColumnName("repartoID");
            entity.Property(e => e.Fila)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fila");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.RepartoCod)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("repartoCOD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
