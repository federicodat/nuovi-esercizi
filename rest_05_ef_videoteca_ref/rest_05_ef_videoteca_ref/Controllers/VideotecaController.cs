using Microsoft.AspNetCore.Mvc;
using rest_05_ef_videoteca_ref.Controllers;
using rest_05_ef_videoteca_ref.Models;
using rest_05_ef_videoteca_ref.services;
namespace rest_05_ef_videoteca_ref.Controllers; 

[ApiController]
[Route("api/videoteche")]
public class VideotecaController : Controller
{
    private readonly VideotecaService _service;
    
        public  VideotecaController(VideotecaService service)   

    {
        _service = service;
    }
    [HttpGet("{varCodice}")]
    public ActionResult<VideotecaDTO?> CercaPerCodice(string varCodice)
    {
        if (string.IsNullOrWhiteSpace(varCodice))
            return BadRequest();

        VideotecaDTO? risultato = _service.Cerca(varCodice
            );

 
        if (risultato is not null)
            return Ok(risultato);

        return NotFound();
    }
}
   
