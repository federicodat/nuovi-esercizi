using Microsoft.EntityFrameworkCore;
using rest_ef_06_migrazione.Models;

namespace rest_ef_06_migrazione.Context
{
  
        public class CinemaContext : DbContext
        {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        public DbSet<Film> Pellicole { get; set; }
    }

}

