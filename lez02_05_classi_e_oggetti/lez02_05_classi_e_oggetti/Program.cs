using lez02_05_classi_e_oggetti.classes;

namespace lez02_05_classi_e_oggetti
{
    internal class Program
    {


        static void Main(string[] args)
        {
             automobile ford = new automobile();
            ford.colore = "blu";
            ford.cilindrata = 2000;
            ford.modello = "focus";
            ford.Stampadettaglio();

             automobile fiat = new automobile();
            fiat.colore = "giallo";
            fiat.cilindrata = 1000;
                fiat.modello = "panda";
            fiat.Stampadettaglio();

             automobile ferrari = new automobile();
            ferrari.colore = "rosso";
            ferrari.cilindrata = 3000;
            ferrari.modello = "modena";
            ferrari.Stampadettaglio();
            //Console.WriteLine(ferrari.colore);
        }
    }
}
