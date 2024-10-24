
using Microsoft.AspNetCore.Mvc;
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models;
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Services;
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Controllers;
namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Controllers;

 
[ApiController]
[Route("api/Reparti")]
public class RepartoController : Controller
{
    private readonly RepartoService _service;

    public RepartoController(RepartoService service)

    {
        _service = service;
    }
    [HttpGet("{varCodice}")]
    public ActionResult<RepartoDTO?> CercaPerCodice(string varCodice)
    {
        if (string.IsNullOrWhiteSpace(varCodice))
            return BadRequest();

        RepartoDTO? risultato = _service.Cerca(varCodice
            );


        if (risultato is not null)
            return Ok(risultato);

        return NotFound();
    }

    [HttpGet("lista")]
    public ActionResult<List<RepartoDTO>>Listarep()
    {
        return _service.Lista().ToList();

    }
    [HttpPost]
    public ActionResult InserisciReparto(RepartoDTO rDto)
    {
             
        //if ((rDto.Fil is not null && rDto.Fil.Trim().Length < 2) || (rDto.Nom is not null && rDto.Nom.Trim().Length < 2))
        //    return BadRequest();
        if (rDto.Fil is   null || rDto.Nom is   null)
            return BadRequest();
        
            bool risultato = _service.Inserisci(rDto);

            if (risultato)
                return Ok();
            else return BadRequest();
         
         
    }

    [HttpDelete]
    public ActionResult delete(string varCodice)
        {
         
        if (varCodice is   null)
            return BadRequest();

       
            bool risultato = _service.Delete(varCodice);
        if (risultato)
            return Ok();
        else return NotFound();

    }

 

    [HttpPut]
    public IActionResult Modificarep(RepartoDTO objrep)
    {
        //if(objrep.Cod is null || objrep.Nom is null || objrep.Fil is null )
        //    return BadRequest();

        bool risultato = _service.Update(objrep);
        if (risultato)
            return Ok();
        else return NotFound();


    }
}

 