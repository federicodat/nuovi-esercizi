using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models;
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Services;
using Microsoft.AspNetCore.Mvc;

namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Controllers
{
    [ApiController]
    [Route("api/Prodotti")]
    public class ProdottoController : Controller
    {
        private readonly ProdottoService _service;

        public ProdottoController(ProdottoService service)

        {
            _service = service;
        }
        [HttpGet("{varCodice}")]
        public ActionResult<ProdottoDTO?> CercaPerCodice(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            ProdottoDTO? risultato = _service.Cerca(varCodice
                );


            if (risultato is not null)
                return Ok(risultato);

            return NotFound();
        }

        [HttpGet("lista")]
        public ActionResult<List<ProdottoDTO>> Listapro()
        {
            return _service.Lista().ToList();

        }
        [HttpPost]
        public ActionResult InserisciProdotto(ProdottoDTO pDto )
       // public ActionResult InserisciProdotto(ProdottoDTO pDto )
        {

            
            if (pDto.Des is null || pDto.Nom is null || pDto.Prez is null  )
                return BadRequest();

            bool risultato = _service.Inserisci(pDto );

            if (risultato)
                return Ok();
            else return BadRequest();


        }

        [HttpDelete]
        public ActionResult delete(string varCodice)
        {

            if (varCodice is null)
                return BadRequest();


            bool risultato = _service.Delete(varCodice);
            if (risultato)
                return Ok();
            else return NotFound();

        }



        [HttpPut]
        public IActionResult Modificapro(ProdottoDTO objpro)
        {
       

            bool risultato = _service.Update(objpro);
            if (risultato)
                return Ok();
            else return NotFound();


        }
    }
}
