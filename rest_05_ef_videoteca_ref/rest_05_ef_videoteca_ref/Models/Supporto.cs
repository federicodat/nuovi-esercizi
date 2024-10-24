using System.ComponentModel.DataAnnotations.Schema;

namespace rest_05_ef_videoteca_ref.Models
{

    [Table ("Supporto")]
    public class Supporto
    {
        public int SupportoId { get; set; }

        public string Codice { get; set; } = null!;

        public string Titolo { get; set; } = null!;

        public int? Anno { get; set; }

        public bool? Disponibilita { get; set; }

        public string Tipo { get; set; } = null!;
        public int VideotecaRif { get; set; }
    }
}
