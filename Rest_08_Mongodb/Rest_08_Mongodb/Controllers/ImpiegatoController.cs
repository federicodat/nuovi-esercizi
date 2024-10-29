using Microsoft.AspNetCore.Mvc;
using Rest_08_Mongodb.Models;
using Rest_08_Mongodb.Services;

namespace Rest_08_Mongodb.Controllers
{
    [ApiController]
    [Route("api/impiegati")]
    public class ImpiegatoController : Controller
    {
        private readonly ImpiegatoService _service;
            
         public  ImpiegatoController( ImpiegatoService service)

        {   _service = service;
        }

        [HttpPost]
        public IActionResult Inserisci(ImpiegatoDTO objDto)
        {
            if (ModelState.IsValid)
            {
                if (_service.Inserisci(objDto))
                    return Ok(new Risposta() { Status = "SUCCESS" });
            }
            return BadRequest();    
        }


        [HttpGet]
      

        public ActionResult<Risposta> Lista()
        {
            return Ok(new Risposta()
            {
                Status = "SUCCESS",
                Data = _service.CercaTutti()
            });
        }

        [HttpGet("{varMatr}")]
        public ActionResult<Risposta> CercaPerCodice(string varMatr)
        {
            ImpiegatoDTO? impDto = _service.CercaPerMatricola(varMatr);

            if (impDto is null)
                return NotFound(new Risposta()
                {
                    Status = "ERROR",
                    Data = "Matricola non trovata"
                });

            return Ok(new Risposta()
            {
                Status = "SUCCESS",
                Data = impDto
            });
        }
       
        [HttpDelete("{varMatr}")]
        public IActionResult Elimina(string varMatr)
        {

            return Ok(new Risposta()
            {
                Status = "SUCCESS",
                Data = _service.elimina(varMatr)
            });

         
        }

    }
}
