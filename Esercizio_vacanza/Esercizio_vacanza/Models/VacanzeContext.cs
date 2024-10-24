using Microsoft.EntityFrameworkCore;

namespace Esercizio_vacanza.Models
{
    public class VacanzeContext : DbContext
    {
        public VacanzeContext(DbContextOptions<VacanzeContext> options
         ) : base(options)
        {
        }
        public DbSet<Pacchetto> Pacchetti { get; set; }
        public DbSet<Destinazione> Desinazioni { get; set; }
        public DbSet<Recensione> Recensioni { get; set; }

    
}
}
