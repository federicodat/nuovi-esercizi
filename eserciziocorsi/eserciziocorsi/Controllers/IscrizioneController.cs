using eserciziocorsi.Models;
using eserciziocorsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace eserciziocorsi.Controllers
{
    [ApiController]
    [Route("Corsi/iscrizioni")]

    public class IscrizioneController : Controller
    {
        private readonly IscrizioneService _service;
        public IscrizioneController(IscrizioneService service)

        {
            _service = service;
        }


        [HttpPost]
        public ActionResult inserisciIscrizione(IscrizioneDTO iDto)
        // public ActionResult InserisciProdotto(ProdottoDTO pDto )
        {


            if (iDto.Nom is null || iDto.Cog is null || iDto.Ema is null)
                return BadRequest();

            bool risultato = _service.Inserisci(iDto);

            if (risultato)
                return Ok();
            else return BadRequest();


        }

    }


}
