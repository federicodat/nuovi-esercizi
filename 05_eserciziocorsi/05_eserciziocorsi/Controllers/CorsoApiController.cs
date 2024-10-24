using _05_eserciziocorsi.Models;
using _05_eserciziocorsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace _05_eserciziocorsi.Controllers
{
    [ApiController]
    [Route("api/corso")]
    public class CorsoApiController : Controller
    {
        private readonly CorsoApiService _service;

        public CorsoApiController(CorsoApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CorsoDTO>> Lista()
        {
            return Ok(_service.List());
        }
    }
}