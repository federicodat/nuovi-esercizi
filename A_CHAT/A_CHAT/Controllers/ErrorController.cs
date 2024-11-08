using Microsoft.AspNetCore.Mvc;

namespace A_CHAT.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Generic()
        {
            return View();
        }
    }
}
