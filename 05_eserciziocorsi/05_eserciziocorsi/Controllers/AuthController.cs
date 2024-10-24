using _05_eserciziocorsi.Models;
using _05_eserciziocorsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace _05_eserciziocorsi.Controllers

{
    public class AuthController : Controller
    {
        private readonly AdminService _service;

        public AuthController(AdminService service)
        {
            _service = service;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verifica(AdminDTO adDto)
        {

            if (string.IsNullOrWhiteSpace(adDto.User) || string.IsNullOrWhiteSpace(adDto.Pass))
                return Redirect("/Auth/Login");

            if (_service.VerificaUsernamePassword(adDto))
            {
                HttpContext.Session.SetString("userLogged", "ADMIN");
                return Redirect("/Corso/Lista");
            }

            return Redirect("/Auth/Login");
        }

    }
}