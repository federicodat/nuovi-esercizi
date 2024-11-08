using A_CHAT.Models;
using A_CHAT.Repos;
using A_CHAT.Services;
using Microsoft.AspNetCore.Mvc;

namespace A_CHAT.Controllers
{
    [ApiController]
    [Route("api/chat")]
    public class ChatApiController : Controller
    {

        private readonly ChatService _service;

        public ChatApiController(ChatService service)

        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<ChatDTO>> Listams()
        {
            return _service.Lista().ToList();

        }
        [HttpPost]
        public IActionResult InserisciMess(ChatDTO objDto)
        {
            if (string.IsNullOrWhiteSpace(objDto.mess) || string.IsNullOrWhiteSpace(objDto.ute))
                return BadRequest();

            bool risultato = _service.InserisciMess(objDto);
                
                //ChatService.GetInstance().InserisciMess(objDto);
 

            if (risultato)
                return Ok();

            return BadRequest();
        }

    }
}
