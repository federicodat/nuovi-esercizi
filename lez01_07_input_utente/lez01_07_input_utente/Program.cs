using System.Security.Cryptography.X509Certificates;

namespace lez01_07_input_utente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* crea
            /*
            * Creare un programma che in input prenda il nome, cognome ed età dell'utente 
            * e che in output lo saluti e gli dica se è maggiorenne o minorenne.
             */

            Console.Write("inserisci il nome: ");
            string? inputnome =Console.ReadLine();
            Console.Write("inserisci il cognome: ");
            string? inputcognome = Console.ReadLine();
            Console.Write("inserisci età: ");
            //string? inputeta = Console.ReadLine();
            //int eta = Convert.ToInt32(inputeta);
            // ottimizzata
            try
            {
                int eta = Convert.ToInt32(Console.ReadLine());
                

                string? risultato  ;
                if (eta >= 18)
                { risultato="maggiorenne "; }

                else
                { risultato="minorenne"; }
                Console.WriteLine($"ciao sei  {inputnome} {inputcognome} , {risultato} ");
            }
            //---eccezioni

            catch(FormatException  fe)
            { Console.WriteLine("formato non ammesso "); }
            catch (OverflowException oe)
            { Console.WriteLine("numero troppo grande non ammesso "); }

            catch (Exception ex)
              { Console.WriteLine("ERRORE "); }



            //------------fine
        }
    }
}
