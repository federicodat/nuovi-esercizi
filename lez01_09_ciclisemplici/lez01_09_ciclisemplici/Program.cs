using System;

namespace lez01_09_ciclisemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* while (condizione)
             * operazione da iterare
             */


            //int indice = 0;
            //int intmax = 5;
            //while (indice < intmax)
            //{
            //    Console.WriteLine($"finito, sono a num  {indice +1}");
            //    indice++;
            //}


            // ciclo do

            //int indice = 0;
            //int max = 3;

            //do 
            //{
            //    Console.WriteLine($"finito, sono a num  {indice + 1}");
            //    indice++;
            //} while (indice < max);


            //ciclo infinito

            //bool inserimentoabilitato =true;
            //while (inserimentoabilitato)
            //{
            //    Console.WriteLine("chi vuoi salutare ? digita Q per uscire");
            //    string? inpututente = Console.ReadLine();

            //    if (inpututente is not null && inpututente.Equals("Q"))
            //        inserimentoabilitato = false;
            //    else
            //        Console.WriteLine($"ciao, {inpututente} ");
            //}

            /* 
            * Scrivere un sistema di gestione invitati alla propria festa
            * L'inserimento avviene tramite console e prende in input, in tre tempi diversi,
            * il nome, il cognome ed il numero di telefono.
            * 
            * All'uscita del programma verrà stampato l'elenco delle persone precedentemente inserite separato da virgola.
            *
            *TIP: Crea una stringa all'inizio del programma che ti potrà essere utile per aggiungere gli invitati.
            */
            string? nome  ;
            //string? cognome  ;
            //string? telefono ;

            bool inserimentoabilitato = true;
            while (inserimentoabilitato)
            {
                Console.WriteLine("inserire nuovo invitato, digita Q per terminare");
                string? inputdato = Console.ReadLine();
                //string? nome = Console.ReadLine();
                //string? cognome = Console.ReadLine();
                //string? telefono = Console.ReadLine();

                if (inputdato is not null && inputdato.Equals("Q"))
                    inserimentoabilitato = false;
                else
                    Console.Write("inserire nome");
                nome = Console.ReadLine();

            }
            //-----------------------------
            //end
        }
    }
}
