using _05_eserciziocorsi.Models;
using Microsoft.EntityFrameworkCore;

namespace _05_eserciziocorsi.Contex
{
    public class PoloFormativoContext : DbContext
    {
        public PoloFormativoContext(DbContextOptions<PoloFormativoContext> options) : base(options) { }

        public DbSet<Admin> Amministratori { get; set; }
        public DbSet<Corso> Corsi { get; set; }
    }
}