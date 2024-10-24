using Microsoft.EntityFrameworkCore;

namespace rest_05_ef_videoteca_ref.Models
{
    public class BlockbusterContex : DbContext
    {
        public BlockbusterContex(DbContextOptions<BlockbusterContex> options
         ) :base(options)
        { 
        }
        public DbSet<Videoteca> Videoteche { get; set; }
        public DbSet<Supporto> Supporti { get; set; }

    }
}
 