using Microsoft.AspNetCore.Mvc;
using rest_02_ef_libreria.Models;
using rest_02_ef_libreria.Repository;
using System.Diagnostics.CodeAnalysis;

namespace rest_02_ef_libreria.Controllers
{
    [ApiController]
    [Route("api/libri")]
    public class LibroController : Controller
    {
        [HttpGet]
        public ActionResult<List<Libro>> ElencoLibri()
        {

            List<Libro> elenco = LibroRepo.GetInstance().GetAll();
            return Ok(elenco);
        }

        [HttpGet("{varCodi}")]
        public ActionResult<List<Libro>> CercaLibroPerCodice(string varCodi)
        {
            Libro? risu = LibroRepo.GetInstance().GetByCodice(varCodi);
            if (risu is not null)

                return Ok(risu);
            return NotFound();
        }


        [HttpPost]
        public IActionResult InserisciLibro(Libro objLib)
        {

            if (LibroRepo.GetInstance().Insert(objLib))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{varCodice}" )]
        public IActionResult EliminaLibro(string varCodice)
        {
            Libro? lib = LibroRepo.GetInstance().GetByCodice(varCodice);
            if (lib is not null)
            {
                if (LibroRepo.GetInstance().Delete(lib.LibroId))
                    return Ok();

               
            }
            return BadRequest();
        }


        [HttpPut]
        public IActionResult ModificaLibro(Libro objLib)
        {
           if(  LibroRepo.GetInstance().Update(objLib))            
            
                    return Ok();

            return BadRequest();

        }
    }
    }

