using A_CHAT.Models;
using A_CHAT.Repos;
using A_CHAT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace A_CHAT.Controllers
{
 
    public class UtenteController : Controller
    {
   
        
            private readonly UtenteService _service;
            private readonly ILogger<UtenteController> _logger;

            public UtenteController(UtenteService service, ILogger<UtenteController> logger)
            {
                _service = service;
                _logger = logger;
            }

            private bool IsAutorizzato()
            {
                string? risultatoSess = HttpContext.Session.GetString("userLogged");
                if (risultatoSess is null && risultatoSess != "ADMIN")
                    return false;

                return true;
            }

            public IActionResult Lista()
            {
                if (!IsAutorizzato())
                {
                    _logger.LogError("Errore, utente non autorizzato sull'endpoint Utente/Lista");
                    return Redirect("/Auth/Login");
                }


                _logger.LogInformation("Utente autorizzato a vedere Lista");
                IEnumerable<Utente> elenco = _service.List();

                return View(elenco);
            }
     

    
 
         

            public IActionResult Sblocca(string varUsername)
        {
             if (string.IsNullOrEmpty(varUsername))
            // if (string.IsNullOrEmpty(objUte.username))
                return Redirect("/Errore");

            Utente? ute = _service.CercaPerCodice(varUsername);
            if (ute is not null)
            {
                //ute.username = Utente.username;
                //ute.passw = objUte.passw;   
                //ute.email = objUte.email;
                //ute.richiesta = objUte.richiesta;
                ute.isbloc = false;
            

                if (_service.ModificaUtente(ute))
                    return Redirect("/Utente/Lista");
            }

            return Redirect("/Errore");
        }

        public IActionResult Blocca(string varUsername)
        {
            if (string.IsNullOrEmpty(varUsername))
                // if (string.IsNullOrEmpty(objUte.username))
                return Redirect("/Errore");

            Utente? ute = _service.CercaPerCodice(varUsername);
            if (ute is not null)
            {
                //ute.username = Utente.username;
                //ute.passw = objUte.passw;   
                //ute.email = objUte.email;
                //ute.richiesta = objUte.richiesta;
                ute.isbloc = true;


                if (_service.ModificaUtente(ute))
                    return Redirect("/Utente/Lista");
            }

            return Redirect("/Errore");
        }

        public IActionResult Cancella(string varUsername)
        {
            {
                if (_service.EliminaUtente(varUsername))
                {
                    _logger.LogInformation("Utente autorizzato a vedere blocca");
                    return Redirect("/Utente/Lista");
                }


            }

            return BadRequest();
        }

         

    }
}
