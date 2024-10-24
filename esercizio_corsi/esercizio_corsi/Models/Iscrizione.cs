using System.ComponentModel.DataAnnotations.Schema;

namespace esercizio_corsi.Models
{
    [Table("Iscrizione")]
    public class Iscrizione
 
    {
        public int corsiiscrizioneID { get; set; }
        public string codiscriz { get; set; } = null!;
        public string corsoRIF { get; set; } = null!;
        public string corsistaRIF { get; set; } = null!;
   


    }
}
