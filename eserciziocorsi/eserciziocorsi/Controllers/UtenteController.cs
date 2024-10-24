using eserciziocorsi.Models;
using eserciziocorsi.Repository;
using eserciziocorsi.Services;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;

namespace eserciziocorsi.Controllers
{
    [ApiController]
    [Route("Utenti")]

 
        public class UtenteController : Controller
        {
            private readonly UtenteService _service;

            public UtenteController(UtenteService service)

            {
                _service = service;
            }
        [HttpGet("lista")]
        public ActionResult<List<UtenteDTO>> listaute()
        {
            return _service.Lista().ToList();

        }


        [HttpGet("{varute}")]
        public ActionResult<Utente?> Cercautente(string varute)
        {
            if (string.IsNullOrWhiteSpace(varute))
                return BadRequest();

            UtenteDTO? utl = UtenteService.GetInstance().Cercaute(varute);   
            if (utl is not null)
                return Ok(utl);

            return NotFound();
        }

        //public IActionResult VerificaCredenziali( Utente objUte)
        //{
        //    if (string.IsNullOrWhiteSpace(objUte.userid) || string.IsNullOrWhiteSpace(objUte.passw))
        //        return Redirect("/Autenticazione/Login");

        //    if (objUte.userid == "giovanni" && objUte.Password == "pace")
        //    {
        //        HttpContext.Response.Cookies.Append("utenteLoggato", "ADMIN");
        //        return Redirect("/Autenticazione/Profiloamministratore");
        //    }

        //    if (objUte.Username == "valeria" && objUte.Password == "verdi")
        //    {
        //        HttpContext.Response.Cookies.Append("utenteLoggato", "USER");
        //        return Redirect("/Autenticazione/Profiloutente");
        //    }

        //    return Redirect("/Autenticazione/Login");
        //}

        //public IActionResult Profiloamministratore()
        //{
        //    string? valoreCookie = HttpContext.Request.Cookies["utenteLoggato"];

        //    if (valoreCookie != null && valoreCookie == "ADMIN")
        //        return View();

        //    return Redirect("/Autenticazione/Login");
        //}

        //public IActionResult Profiloutente()
        //{
        //    string? valoreCookie = HttpContext.Request.Cookies["utenteLoggato"];

        //    if (valoreCookie != null && valoreCookie == "USER")
        //        return View();

        //    return Redirect("/Autenticazione/Login");
        //}
    }
    }

