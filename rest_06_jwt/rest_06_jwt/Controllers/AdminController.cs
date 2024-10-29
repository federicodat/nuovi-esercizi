using Microsoft.AspNetCore.Mvc;
using rest_06_jwt.Models;
namespace rest_06_jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        [HttpGet("profilo")]
        [AutorizzaUtentePerTipo("ADMIN")]
        public IActionResult Profilo()
        {
            return Ok(new
            {
                status = "SUCCESS",
                dati = "Profilo dell'amministratore"
            });
        }
    }
}
