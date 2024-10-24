using eserciziocorsi.Models;
using eserciziocorsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace eserciziocorsi.Controllers
{
    [ApiController]
    [Route("Corsi")]

    public class CorsoController : Controller
    {
       
        
            private readonly CorsoService _service;

            public CorsoController(CorsoService service)

            {
                _service = service;
            }

        [HttpGet("lista")]
        public ActionResult<List<CorsoDTO>> Listacorsi()
        {
            return _service.Lista().ToList();

        }
    }
}
 