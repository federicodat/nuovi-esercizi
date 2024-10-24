using Esercizio_vacanza.Models;
using Esercizio_vacanza.Services;
using Microsoft.AspNetCore.Mvc;

namespace Esercizio_vacanza.Controllers
{
    [ApiController]
    [Route("api/Pacchetti")]
    public class PacchettoController : Controller
    {
        private readonly PacchettoService _service;

        public PacchettoController(PacchettoService service)

        {
            _service = service;
        }

        [HttpGet("lista")]
        public ActionResult<List<PacchettoDTO>> Listapac()
        {
            return _service.Lista().ToList();

        }
        [HttpGet("{varCodice}")]
        public ActionResult<PacchettoDTO?> CercaPerCodice(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            PacchettoDTO? risultato = _service.Cerca(varCodice
                );


            if (risultato is not null)
                return Ok(risultato);

            return NotFound();
        }


    }
}
