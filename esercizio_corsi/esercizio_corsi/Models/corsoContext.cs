using Microsoft.EntityFrameworkCore;

namespace esercizio_corsi.Models
{
    public class corsoContext : DbContext
    {
  
        public corsoContext(DbContextOptions<corsoContext> options
         ) : base(options)
        {
        }
        public DbSet<Corso> Corsi { get; set; }
        public DbSet<Corsista> Corsisti { get; set; }
        public DbSet<Iscrizione> Iscrizioni { get; set; }

    }
}
