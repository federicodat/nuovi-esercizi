using Microsoft.AspNetCore.Mvc;
using rest04_ef_videoteca.Models;
using rest04_ef_videoteca.Services;

namespace rest04_ef_videoteca.Controllers
{
    [ApiController]
    [Route("api/videoteche")]
    public class VideotecaController : Controller
    {
        /// <summary>
        /// Metodo GET per il recupero dei dettagli di una singola Videoteca
        /// </summary>
        /// <param name="varCodice">Codice univoco con formato GUID che identifica una videoteca</param>
        /// <returns></returns>
        [HttpGet("{varCodice}")]
        public ActionResult<VideotecaDTO?> VisualizzaVideoteca(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            VideotecaDTO? risultato = VideotecaService.GetInstance().CercaVideoteca(varCodice);
            if (risultato is not null)
                return Ok(risultato);

            return NotFound();
        }

        [HttpGet]
        public ActionResult<List<VideotecaDTO>> ElencoVideoteche()
        {
            return Ok(VideotecaService.GetInstance().CercaTutteVideoteche());
        }
    }
}