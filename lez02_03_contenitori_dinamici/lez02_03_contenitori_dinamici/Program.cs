using System;
using System.ComponentModel.Design;

namespace lez02_03_contenitori_dinamici
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<string> Lista = new List<string>();

            //Lista.Add("gianni");
            //Lista.Add("aldo");
            //Lista.Add("valeria");

            //for (int i = 0; i < Lista.Count; i++) { 

            //    Console.WriteLine(Lista[i]);
                 

            //}


            /*
                * Creare un sistema di input che mi permetta di aggiungere invitati ad una lista, 
                * che abbia una funzione di stampa della lista e che mi permetta di interrompere il programma digitando Q
                    */

            bool insAbi = true;
            List<string> Elenco = new List<string>();

            while (insAbi)
            {
                Console.Write("Dimmi cosa vuoi fare:\n +" +
                    "I per inserimento \n +" +
                    "s stampa\n +" +
                    "Q per uscire");

                string? inputUtente = Console.ReadLine();
                  
                if (inputUtente != null) inputUtente=inputUtente.ToUpper();

                switch (inputUtente) 
                {
                    case "I":
                        Console.WriteLine("dammi nome:");
                        string? varnome = Console.ReadLine(); 
                        
                        if (varnome   is not null && !varnome.Trim().Equals("") )
                                                     
                        
                        {
                            Elenco.Add(varnome);  
                            Console.WriteLine("inserito");
                        }
                        else 
                                Console.WriteLine("non accetto vuoto");
                        break;
                         
                             

                break; 
                    case "S":
                        Console.Write( "elenco invitati: ");
                        for (int i = 0; i < Elenco.Count; i++)
                        Console.Write($"  {Elenco[i]} ");
                break; 
                    case "Q":
                         insAbi=!insAbi;
                        break;
                 
                   default:
                        Console.WriteLine("comando errato");
                        break;
                }

                //Console.WriteLine($"elenco invitati:\n{Elenco}");




            }
            //for (int i = 0; i < Lista.Count; i++) { 

            //    Console.WriteLine(Lista[i]);


            //}

            //----f
        }
    }
}
