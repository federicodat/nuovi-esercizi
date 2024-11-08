using System.ComponentModel.DataAnnotations.Schema;

namespace A_CHAT.Models
{
    [Table("Amministratore")]
    public class Amministratore
    {
    
        
            [Column("amministratoreID")]
            public int Id { get; set; }

            [Column("usern")]
            public string User { get; set; } = null!;

            [Column("passw")]
            public string Pass { get; set; } = null!;

        }
    }