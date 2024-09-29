using lez03_03_costruttori.classi;
using System.Runtime.InteropServices;

namespace lez03_03_costruttori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new costruisce oggetto automobile e lo restituisce  su focus
            // Automobilecs focus  = new Automobilecs();
            //focus.Cilindrata = 1300;
            //focus.Marca = "Ford";
            //focus.Colore = "rosso";


            Automobilecs ypsilon = new Automobilecs("lancia", 1200, "gialla");

            Automobilecs lancia = new Automobilecs("lancia", 1200, "gialla");
            Console.WriteLine(lancia);

            // Console.WriteLine("Hello, World!");
        }
    }
}
