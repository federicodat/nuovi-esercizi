using System.ComponentModel.DataAnnotations.Schema;

namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models
{
    [Table("Prodotto")]
    public class Prodotto
    {
        public int ProdottoID { get; set; }

        public string CodiceBarre { get; set; } = null!;

        public string Nome { get; set; } = null!;
        public string? Descrizione { get; set; }  

        public Decimal? Prezzo { get; set; }
        public int Quantita { get; set; } 
        public int RepartoRif { get; set; }

    }
}