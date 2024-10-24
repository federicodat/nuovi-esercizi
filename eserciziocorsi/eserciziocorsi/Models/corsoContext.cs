using Microsoft.EntityFrameworkCore;

namespace eserciziocorsi.Models
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
        public DbSet<Utente> Utenti { get; set; }

    }
}
