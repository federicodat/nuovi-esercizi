using asp_web_01_introduzione.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_web_01_introduzione.Controllers
{
    public class HelloController : Controller
    {


        private string SalutaGenerico()
        { return "ciao sono giovanni"; }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Titolo = "sono la pag index";
            ViewBag.Sottotitolo = "sono sottotitolo";
            ViewBag.Numero = 35;
            ViewBag.saluta = SalutaGenerico();

            Persona val = new Persona()
            { Nominativo = "valeria verdi",
                CodFis = "vvvvvv"
            };

            return View(val);

        }


        [HttpGet]
        public IActionResult Lista()
        {
            List<Persona> elenco = new List<Persona>()
            {
                new Persona() { Nominativo = "Giovanni Pace", CodFis = "PCAGNN" },
                new Persona() { Nominativo = "Valeria Verdi", CodFis = "VLRVRD" },
                new Persona() { Nominativo = "Mario Rossi", CodFis = "MRRRSS" }
            };

            return View(elenco);
        }
    }
}