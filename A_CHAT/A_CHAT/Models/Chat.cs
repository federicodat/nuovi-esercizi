using System.ComponentModel.DataAnnotations.Schema;

namespace A_CHAT.Models
{
    [Table("Chat")]
    public class Chat
    {
        public int ChatID { get; set; }

        public string Codice { get; set; } = Guid.NewGuid().ToString(); // Per replicare NEWID()

        public string Messaggio { get; set; } = string.Empty; // Imposta un valore di default per non null

        public DateTime DatMes { get; set; } // Per replicare GETDATE()

        public int UtenteRif { get; set; }
       
          
    }
}