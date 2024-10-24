using System.ComponentModel.DataAnnotations.Schema;

namespace Esercizio_vacanza.Models
{
    [Table("Recensione")]
    public class Recensione
    {
        public int RecensioneID { get; set; }

        public string Utente { get; set; } = null!;

        public int Voto { get; set; }  
        public string? commento { get; set; }
        public DateTime datarece { get; set; }

        public int PacchettoRif { get; set; }

    }
}
