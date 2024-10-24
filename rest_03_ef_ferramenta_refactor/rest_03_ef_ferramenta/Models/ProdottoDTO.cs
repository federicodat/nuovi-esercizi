namespace rest_03_ef_ferramenta.Models
{
    public partial class ProdottoDTO   {
  

        public string Cod { get; set; } = null!;

        public string Nom { get; set; } = null!;

        public string? Des { get; set; }

        public decimal? Pre{ get; set; }

        public int Qua { get; set; }

        public RepartoDTO? Rep { get; set; }    

   

        
    }

}
