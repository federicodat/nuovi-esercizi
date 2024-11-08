using Microsoft.AspNetCore.Mvc;

namespace migra_mongo.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            string path = "C:\\Users\\federico.dattilo\\source\\persona.csv";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string? line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }
    }
}
