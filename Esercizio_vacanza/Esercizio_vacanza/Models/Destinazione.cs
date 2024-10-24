using System.ComponentModel.DataAnnotations.Schema;

namespace Esercizio_vacanza.Models
{
    [Table("Destinazione")]
    public class Destinazione
    {
        public int destinazioneID { get; set; }

        public string nome { get; set; } = null!;

        public string descrizione { get; set; } = null!;
        public string paese { get; set; } = null!;
        public string foto { get; set; }



    }
}
