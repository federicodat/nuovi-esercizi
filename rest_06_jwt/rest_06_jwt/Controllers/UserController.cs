using Microsoft.AspNetCore.Mvc;
using rest_06_jwt.Models;

namespace rest_06_jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  // cosi utilizza il nome del controller
    public class UserController : Controller
    {
        [HttpGet("profilo")]
        [AutorizzaUtentePerTipo("USER") ]//localhost:1234/api/auth/login
        public IActionResult Profilo()
        {

            return Ok( new
            {
                status = "SUCCESS",
                dati = "profilo user"
            } );
        }
            
        }
    }

