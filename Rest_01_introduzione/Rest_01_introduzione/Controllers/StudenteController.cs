using Microsoft.AspNetCore.Mvc;
using Rest_01_introduzione.Models;

namespace Rest_01_introduzione.Controllers
{
    [ApiController]
        [Route("api/studente")]
    public class StudenteController : Controller
    {
        [HttpGet("dettaglio")]
        public ActionResult<Studente?> DettaglioStudente()
        {
            Studente stu = new Studente()
            {
                Id = 2,
                Nome = "gianni",
                Cognome = "pace",
                Matricola = "ghghg"
            };

            return Ok(stu);
        }


        [HttpGet("lista")]
        public ActionResult<List<Studente>> ElencoStudenti()
        {
            List<Studente>  elenco= new List<Studente>()
            {
               new Studente() { Id=1 , Nome="gianni",Cognome="pace", Matricola="78787"},
                new Studente() { Id=1 , Nome="pipo",Cognome="pipi", Matricola="eeee"},
                 new Studente() { Id=1 , Nome="lillo",Cognome="lallo", Matricola="78787"}

            };

            return Ok(elenco);
        }
    }
}