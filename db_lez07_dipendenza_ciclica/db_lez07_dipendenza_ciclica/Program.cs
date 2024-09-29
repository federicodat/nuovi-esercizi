using db_lez07_dipendenza_ciclica.Models;

namespace db_lez07_dipendenza_ciclica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Albergo gh = new Albergo()
            { Nome = "grand Hotel", Indirizzo="via roma",Stelle =3        };

            Camera aur = new Camera("aurora", 5, "belle", gh);
            Camera eos = new Camera("tramonto", 2, "brutta", gh);

            gh.AggiungiCamera(aur);
            gh.AggiungiCamera(eos);

            Console.WriteLine(gh.ToString());
            //Console.WriteLine(gh.Stampadettaglio());
            //Console.WriteLine(aur.StringaDettaglio());
            //Console.WriteLine(eos.StringaDettaglio());
        }
    }
}
