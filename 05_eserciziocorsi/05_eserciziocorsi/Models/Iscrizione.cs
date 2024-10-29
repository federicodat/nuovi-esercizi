using System.ComponentModel.DataAnnotations.Schema;

namespace _05_eserciziocorsi.Models
{
    [Table("Iscrizione")]
    public class Iscrizione
    {
        [Column("iscrizioneID")]
        public int Id { get; set; }
        [Column("codice")]
        public string? Codice { get; set; }
        [Column("nome")]
        public string Nome { get; set; } = null!;
        [Column("cognome")]
        public string Cognome { get; set; } = null!;
        [Column("email")]
        public string Email { get; set; } = null!;
        [Column("disicr_codi")]
        public string? CodiceDis { get; set; }
        [Column("data_iscr")]
        public DateTime? DataIscr { get; set; }

        [Column("corsoRIF")]
        public int CorsoRIF { get; set; }

        public static implicit operator Iscrizione(IscrizioneDTO v)
        {
            throw new NotImplementedException();
        }
    }
}
