using System.ComponentModel.DataAnnotations.Schema;

namespace eserciziocorsi.Models
{
    [Table("Iscrizione")]
    public class Iscrizione
 
    {
        public int iscrizioneID { get; set; }
        public string codiscriz { get; set; } = null!;
        public string nome { get; set; } = null!;
        public string cogn { get; set; } = null!;
        public string mail { get; set; } = null!;
        public int corsoRIF { get; set; }
      
   


    }
}
