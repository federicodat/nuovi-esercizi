using System.ComponentModel.DataAnnotations.Schema;

namespace A_CHAT.Models
{
    public class ChatDTO
    {
    
    public string cod { get; set; } = null!;
 
    public string mess { get; set; } = null!;
    [Column]
    public DateTime  datm { get; set; }

   //ublic UtenteDTO? ute { get; set; }

        public string ute {get; set; } = null!;

    }
}