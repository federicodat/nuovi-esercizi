using _05_eserciziocorsi.Models;
using _05_eserciziocorsi.Repos;
using _05_eserciziocorsi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _05_eserciziocorsi.Controllers
{
    [ApiController]
    [Route("api/iscrizione")]
    public class IscrizioneApiController : Controller
    {
        private readonly IscrizioneApiService _service;
        public IscrizioneApiController(IscrizioneApiService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Inserisci(IscrizioneDTO iscDto)
        {
            if (
                string.IsNullOrWhiteSpace(iscDto.Nome) ||
                string.IsNullOrWhiteSpace(iscDto.Cognome) ||
                string.IsNullOrWhiteSpace(iscDto.Email))
                return BadRequest();

            if (_service.Insert(iscDto))
                return Ok(
                    new { Disiscrizione = iscDto.CodiceDis }
                    );

            return BadRequest();

          
        }
 

        [HttpGet("{varCodice}")]
        public ActionResult<IscrizioneDTO?> CercaPerCodice(string varCodice)
        {
             
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            IscrizioneDTO? risultato = _service.Cerca(varCodice
                );


            if (risultato is not null)
                return Ok(risultato);

            return NotFound();
        }

        [HttpDelete]
        public ActionResult delete(string varCodice)
        {

            if (varCodice is null)
                return BadRequest();


            bool risultato = _service.Delete(varCodice);
            if (risultato)
                return Ok();
            else return NotFound();

        }
    }
}
