using Esercizio_vacanza.Models;
using Esercizio_vacanza.Services;
using Microsoft.AspNetCore.Mvc;

namespace Esercizio_vacanza.Controllers
{
    [ApiController]
    [Route("api/Recensioni")]


    public class RecensioneController : Controller
    {
        private readonly RecensioneService _service;

        public RecensioneController(RecensioneService service)

        {
            _service = service;
        }

        //[HttpGet("lista")]

        ////public IEnumerable<RecensioneDTO> Lista(string varcod)
        ////{

        ////    {
        ////        return _service.Lista( varcod).ToList();
    
        ////     }
        ////}
        [HttpPost]
        public ActionResult InserisciRecensione(RecensioneDTO rDto)
        {
             
            if (rDto.Ute is null || rDto.Vot <0)
                return BadRequest(); 

            bool risultato = _service.InserisciRecensione(rDto);

            if (risultato)
                return Ok();
            else return BadRequest();


        }
    }
}
