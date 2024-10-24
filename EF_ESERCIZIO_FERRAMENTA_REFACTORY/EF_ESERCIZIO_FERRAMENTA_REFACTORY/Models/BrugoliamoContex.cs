using Microsoft.EntityFrameworkCore;

namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models
{
    public class BrugoliamoContex : DbContext
    {
        public BrugoliamoContex(DbContextOptions<BrugoliamoContex> options
         ) : base(options)
        {
        }
        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Reparto> Reparti { get; set; }

    }
}
