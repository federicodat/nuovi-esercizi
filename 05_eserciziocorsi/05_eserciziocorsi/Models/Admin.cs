using System.ComponentModel.DataAnnotations.Schema;

namespace _05_eserciziocorsi.Models
{
   
    [Table("Amministratore")]
    public class Admin
    {
        [Column("amministratoreID")]
        public int Id { get; set; }

        [Column("usern")]
        public string User { get; set; } = null!;

        [Column("passw")]
        public string Pass { get; set; } = null!;

    }
}