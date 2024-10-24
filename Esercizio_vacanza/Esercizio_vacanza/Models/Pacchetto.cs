using System.ComponentModel.DataAnnotations.Schema;

namespace Esercizio_vacanza.Models
{
    [Table("Pacchetto")]
    public class Pacchetto
    {
        public int pacchettoID { get; set; }

        public string nome { get; set; } = null!;
        public decimal prezzo { get; set; }  

        public string durata { get; set; } = null!;
        public DateOnly dataini { get; set; }  
        public DateOnly datafin { get; set; }  
    


    }
}
