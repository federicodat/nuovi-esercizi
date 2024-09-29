using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq.Expressions;

namespace lez01_05_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nominativo = null!;  //metodo per non far occupare memoria la variabile
            //nominativo = "giovanni";
            //Console.WriteLine(nominativo );


            // ////operazion con string
            // //Console.WriteLine("giovanni" + "pace");

            // int a = 5;
            // int b = 10;
            // Console.WriteLine("la somma dei numeri è" +5 +10);   // diventa 510

            // Console.WriteLine("la somma dei numeri è" + (5 + 10));   // diventa 15

            // Console.WriteLine(5 + 10 + "è la somma dei numeri ");   // diventa 15

            // //-------------
            // /* 
            //  * Scrivere un programma che mandi in output le seguenti due stringhe:
            // * 
            // * Giovanni Pace è 37 anni vecchio ed ha una temperatura corporea di 36.2°
            // * Mario Rossi è 35 anni vecchio ed ha una temperatura corporea di 37.3°
            // */
            // string nominativo = "giovanni pace";
            // int anni = 37;
            // float temperatura = 36.2f;


            // Console.WriteLine(nominativo + " è  " + anni + " vecchio ed ha una temperatura corporea di " + temperatura + "gradi" );
            //// anche con tale operatore interpolazione:
            // Console.WriteLine($" {nominativo}   è  { anni }  anni vecchio ed ha una temperatura corporea di {temperatura } gradi" );


            // //---------------- parentesi graffe definiscono piccolo sottoporgramma

            // Console.WriteLine($"la somma dei numeri è: { 5 + 10}");



            // Console.WriteLine($"la lunghezza del nome è: {nominativo} è  :  {nominativo.Length}");    

            // int lunghezza = nominativo.Length;
            // Console.WriteLine($"la lunghezza del nome è: {nominativo} è  :  {lunghezza}");

            // //--------------
            // //String? frase = "mi piace tanto programmare";

            // //Console.WriteLine(frase);

            // //String? frase = "mi piace tanto \"programmare\"";

            // //Console.WriteLine(frase);


            // //char  prova = "A";

            // String? frase = "sono gianni e mi piace  programmare ";

            // Console.WriteLine(frase.IndexOf("gianni"));
            // Console.WriteLine(frase.IndexOf("gianno"));


            // if (frase.IndexOf("gianni") >= 0)
            // {
            //     Console.WriteLine("trovato");
            // }
            // else {
            //     Console.WriteLine("non trovato");
            //     {
            //---------------------------


            /*
            * Creare un sistema di controllo accessi al ristorante, in input (sotto forma di variabile) ci sarà la temperatura.
            * 
            * Se la temperatura è maggiore o uguale a 37.5° non permettere l'accesso al ristorante.
            * 
            * ATTENZIONE: Non ci vuole un medico per stabilire che al di sotto dei 34° potrebbe esserci qualche problema, 
            * oppure al di sopra dei 42 potrebbe esserci qualche sintomo di una apocalisse zombie
            * (a cui non dovrebbe essere permesso l'accesso). Restituire un errore.
            */


            //float temperatura = 55.0f;
            

            //if (temperatura <34.0f && temperatura > 42.0f)
            //    if (temperatura < 37.5f )
            //         {
            //        Console.WriteLine("vietato");
            //            }

            //    else

            //    {
            //        Console.WriteLine("accesso");
            //    }

            //else
            //{
            //    Console.WriteLine("se more");
            //    }

            ////
            //Console.WriteLine("ciao inserisci  temperatura");
            //string? inputremperatura =Console.ReadLine();
            //Console.WriteLine($" {inputremperatura} ");

            //double temperatura = Convert.ToDouble(inputremperatura);
            //if (temperatura < 34.0d && temperatura > 42.0d)
            //    if (temperatura < 37.5d)
            //    {
            //        Console.WriteLine("vietato");
            //    }

            //    else

            //    {
            //        Console.WriteLine("accesso");
            //    }

            //else
            //{
            //    Console.WriteLine("se more");
            //}



            ////
            //Console.WriteLine("ciao inserisci  temperatura");
            //string? inputremperatura = Console.ReadLine();

            //try
            //{

            //    double temperatura = Convert.ToDouble(inputremperatura);
            
            //}
            //   catch
            //    {

            //    Console.WriteLine("errore inpuT");
            //     }






            Console.WriteLine("ciao inserisci  temperatura");
            string? inputremperatura = Console.ReadLine();

            try
            {
                double temperatura = Convert.ToDouble(inputremperatura);
                if (temperatura >=34.0d && temperatura <= 42.0d)
                //if (temperatura < 42.0d)
                    {
                      if (temperatura < 37.5d)
                             {
                        Console.WriteLine("accesso consentito ");
                         }

                       else

                        {
                        Console.WriteLine("accesso vietato");
                        }
                    }
                else
                    {
                    Console.WriteLine("temperature oltre la vita se more");
                    }
               
            }
            catch
            {

                Console.WriteLine("errore inpuT");
            }




                    //i
                    //fine
                }





            }
         }

