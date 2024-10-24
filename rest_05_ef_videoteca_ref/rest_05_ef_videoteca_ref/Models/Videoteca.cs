using System.ComponentModel.DataAnnotations.Schema;

namespace rest_05_ef_videoteca_ref.Models
{
    [Table("Videoteca")]
    public class Videoteca
    {
        public int VideotecaId { get; set; }

        public string Codice { get; set; } = null!;

        public string Nome { get; set; } = null!;

        public string? Indirizzo { get; set; }

       
    }

}
