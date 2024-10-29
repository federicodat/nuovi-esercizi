using System.ComponentModel.DataAnnotations.Schema;

namespace _05_eserciziocorsi.Models
{
   
    public class IscrizioneDTO
    {
       
     
        public string? Codice { get; set; }
        public string Nome { get; set; } = null!;
       
        public string Cognome { get; set; } = null!;
       
        public string Email { get; set; } = null!;
        
        public string? CodiceDis { get; set; }
       

       
        public CorsoDTO CorsoIscr { get; set; }
    }
}
