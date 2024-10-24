using System.ComponentModel.DataAnnotations.Schema;

namespace esercizio_corsi.Models
{
  
        [Table("Corsista")]
        public class Corsista
        {
            public int corsistaID { get; set; }
            public string nome { get; set; } = null!;
            public string cognome { get; set; } = null!;
            public string mail { get; set; } = null!;

      
    }
    }
 