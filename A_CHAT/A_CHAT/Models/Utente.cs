using System.ComponentModel.DataAnnotations.Schema;

namespace A_CHAT.Models
{ 
     [Table("Utente")]
    public class Utente
    {
        [Column]
        public int utenteID { get; set; }
        [Column]
        public string username { get; set; } = null!;
        [Column]
        public string passw { get; set; } = null!;
        [Column]
        public string email { get; set; }
        [Column]
        public bool isbloc { get; set; }
        [Column ]
        public bool richiesta { get; set; }
      
    }
}