namespace rest04_ef_videoteca.Controllers
{
    public class VideotecaDTO
    {
        public string Cod { get; set; } = null!;

        public string Nom { get; set; } = null!;

        public string? Ind { get; set; }
    }
}