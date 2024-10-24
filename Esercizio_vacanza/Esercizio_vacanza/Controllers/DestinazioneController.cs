using Esercizio_vacanza.Models;
using Esercizio_vacanza.Services;
using Microsoft.AspNetCore.Mvc;
using Esercizio_vacanza.Controllers;

namespace Esercizio_vacanza.Controllers; 

[ApiController]
[Route("api/Destinazioni")]
public class DestinazioneController : Controller
{
    private readonly DestinazioneService _service;

    public DestinazioneController(DestinazioneService service)

    {
        _service = service;
    }

    [HttpGet("lista/")]
    public ActionResult<List<DestinazioneDTO>> Listades()
    {
        return _service.Lista().ToList();

    }
    [HttpGet("lista/{varCodice}")]
    public ActionResult<List<DestinazioneDTO>> Listadespac(string varCodice)
    {
        return _service.Lista().ToList();

    }
}
