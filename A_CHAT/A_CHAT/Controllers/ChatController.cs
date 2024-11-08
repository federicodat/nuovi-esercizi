using A_CHAT.Models;
using A_CHAT.Services;
using Microsoft.AspNetCore.Mvc;

namespace A_CHAT.Controllers
{
    public class ChatController : Controller
    {
        private readonly ChatService _service;

        public ChatController(ChatService service)

        {
            _service = service;
        }

        public ActionResult<List<ChatDTO>> Listams()
        {
           // return _service.Lista().ToList();
            IEnumerable<Chat> elenco = _service.List();
            return View(elenco);
        }

    
         
    }
}
