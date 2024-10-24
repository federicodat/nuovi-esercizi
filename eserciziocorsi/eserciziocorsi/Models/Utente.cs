using System.ComponentModel.DataAnnotations.Schema;

namespace eserciziocorsi.Models
{
    [Table("Utente")]
    public class Utente
    {
        public int utenteID { get; set; }
        public string userid { get; set; } = null!;
        public string passw { get; set; } = null!;
        public string ruolo { get; set; } = null!;
    }
}

