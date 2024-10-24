using System.ComponentModel.DataAnnotations.Schema;

namespace Esercizio_vacanza.Models
{
    [Table("PaccDest")]
    public class PaccDest
    {
        public int paccdestID { get; set; }


        public int PacchettoRif { get; set; }
        public int destinazioneRIF { get; set; }
    }
}
