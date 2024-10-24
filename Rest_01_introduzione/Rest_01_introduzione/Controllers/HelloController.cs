using Microsoft.AspNetCore.Mvc;

namespace Rest_01_introduzione.Controllers
{
    [ApiController]
    [Route("api/hello")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("ciao sono metodo index");
        }

        [HttpGet("ciao")]
        public IActionResult saluta()
        {
            return Ok("ciao fede");
        }

        [HttpGet("saluta/{varNome}")] 
        
        //public IActionResult salutapersonalizzato(string varNome)
        //{
        //    return Ok($" ciao {varNome}");
        //}
        //[HttpGet("saluta/{varNome}{varCognome ")]

        //public IActionResult salutapersonalizzato(string varNome, string varCognome)
        //{
        //    return Ok($" ciao {varNome}  {varCognome} ");
        //}

        [HttpGet("test")]
        public IActionResult TestGet() 
        {
            return Ok(" test di get ");
        }
        [HttpPost("test")]
        public IActionResult TestPost()
        {
            return Ok(" test di post ");
        }
    }
}

