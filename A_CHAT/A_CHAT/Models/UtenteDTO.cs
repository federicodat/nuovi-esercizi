using System.ComponentModel.DataAnnotations.Schema;

namespace A_CHAT.Models
{ 
      
    public class UtenteDTO
    {
 

        public string usern { get; set; } = null!;
      
        public string pas { get; set; } = null!;
     
        public string emai { get; set; }

        public bool isb { get; set; }

        public bool ric { get; set; }

      

    }
}