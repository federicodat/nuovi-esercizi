namespace Esercizio_vacanza.Models
{
    public class PacchettoDTO
    {

        public string nom { get; set; } = null!;
        public decimal prez { get; set; }

        public string dura { get; set; } = null!;
        public DateOnly datai { get; set; }
        public DateOnly dataf { get; set; }
    }
}
