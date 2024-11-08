using A_CHAT.Models;
using A_CHAT.Services;
using Microsoft.AspNetCore.Mvc;

 

namespace A_CHAT.Controllers
{
    [ApiController]

    public class UtenteAPiController : Controller
    {


        private readonly UtenteService _service;
        private readonly ILogger<UtenteController> _logger;

        public UtenteAPiController(UtenteService service, ILogger<UtenteController> logger)
        {
            _service = service;
            _logger = logger;
        }


        //  per gli utenti nuovi
        [HttpPost]
        [Route("api/iscrizione")]
        public IActionResult Inserisci(Utente uDto)
        {
            if (
                string.IsNullOrWhiteSpace(uDto.username) ||
                string.IsNullOrWhiteSpace(uDto.email) ||
                string.IsNullOrWhiteSpace(uDto.passw))

                return BadRequest();
            bool risultato = _service.Insert(uDto);
            if (risultato)
                return Ok();
            else return BadRequest();
        }

        // verifica login utente
        [HttpGet("{varU}/{varP}")]
         
        //[Route("api/login")]
        public ActionResult<UtenteDTO?> CercaPerCodice(string varU, string varP)
  
        {
            if (string.IsNullOrWhiteSpace(varU))
                return BadRequest();
            if (string.IsNullOrWhiteSpace(varP))
               return BadRequest();


            UtenteDTO? risultato = _service.cerca(varU,varP);
             
            if (risultato is not null)
                return Ok(risultato);
           

            return NotFound();
        }
        //public IActionResult Verifica(UtenteDTO uDto)
        //{

        //    if (string.IsNullOrWhiteSpace(uDto.usern) || string.IsNullOrWhiteSpace(uDto.pas))
        //        return Redirect("/api/Login");

        //    if (_service.VerificaUsernamePasswordu(uDto))
        //    {
        //        HttpContext.Session.SetString("userLogged", "utente");
        //        return Redirect("/Chat/Lista");

        //    }

        //    return Redirect("/api/Login");
        //}

    }
}

