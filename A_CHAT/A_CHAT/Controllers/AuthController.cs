using A_CHAT.Models;
using A_CHAT.Services;
using Microsoft.AspNetCore.Mvc;

namespace A_CHAT.Controllers
{
    public class AuthController : Controller
    {
       
            private readonly AmministratoreService _service;

            public AuthController(AmministratoreService service)
            {
                _service = service;
            }

            public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Verifica(AmministratoreDTO adDto)
            {

                if (string.IsNullOrWhiteSpace(adDto.User) || string.IsNullOrWhiteSpace(adDto.Pass))
                return Redirect("/Auth/Login");

            if (_service.VerificaUsernamePassword(adDto))
                {
                    HttpContext.Session.SetString("userLogged", "ADMIN");
                   return Redirect("/Utente/Lista");
                    
                }

                return Redirect("/Auth/Login");
            }

        }
    }
