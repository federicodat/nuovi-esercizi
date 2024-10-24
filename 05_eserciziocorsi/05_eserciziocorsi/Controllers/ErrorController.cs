using Microsoft.AspNetCore.Mvc;

namespace _05_eserciziocorsi.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Generic()
        {
            return View();
        }
    }
}
