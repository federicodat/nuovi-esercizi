
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rest_ef_06_migrazione.Models
{
    [Table("Proiezioni")]
    public class Film
    {
        [Key]
        public int FilmID        { get; set; }

        [Required]
        [MaxLength(250)]
        public string Titolo { get; set; } = null!;

        [MaxLength(250)]
        public string? Descrizione        { get; set; }

        [Required]
        public int  Anno        { get; set; } 
    }
}
