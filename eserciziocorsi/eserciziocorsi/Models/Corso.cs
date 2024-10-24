using System.ComponentModel.DataAnnotations.Schema;

namespace eserciziocorsi.Models
{
      [Table("Corso")]
        public class Corso
        {
            public int corsoID { get; set; }
            public string codice { get; set; } = null!;
            public string nome { get; set; } = null!;
            public string descrizione { get; set; } = null!;
            public decimal prezzo { get; set; }
            public int maxpart { get; set; }
         

        }
    }