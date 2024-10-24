namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models
{
    public class ProdottoDTO
    {
        public string Codi { get; set; } = null!;

        public string Nom { get; set; } = null!;
        public string? Des { get; set; }
        //public float? Prez { get; set; }
       public Decimal? Prez { get; set; }
        public int Qua { get; set; }

        public int rifrep { get; set; } 

    }
}
