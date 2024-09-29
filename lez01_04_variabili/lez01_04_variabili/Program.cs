using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lez01_04_variabili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int? eta=0;
            ////Console.WriteLine(eta);

            //int  numero_intero = 55;
            //Console.WriteLine(numero_intero);


            //float numero_float = 15.7f;
            //Console.WriteLine(numero_float);

            //double numero_double = 15.7d;
            //Console.WriteLine(numero_double);

            //double prova = numero_float;
            //      Console.WriteLine(prova);

            //float prova2 = numero_intero;
            //Console.WriteLine(prova2);

            //----------------------------------
            //   2 operazioni 
            //int valore1 = 8;
            //int valore2 = 5;
            //Console.WriteLine(valore1+valore2);  
            //Console.WriteLine(valore1+valore2);
            //Console.WriteLine(valore1+valore2);
            //Console.WriteLine(valore1+valore2);

            //// 3 operazioni costa di piu
            //int avalore1 = 8;
            //int avalore2 = 5;
            //int somma = avalore1 + avalore2;
            //Console.WriteLine(somma);
            //Console.WriteLine(somma);
            //Console.WriteLine(somma);
            //Console.WriteLine(somma);


            // operazioni complesse
            //Console.WriteLine(15+12.8f+96.78d);  // attenzione al rumore

            //int numero = 15;
            // numero = numero + 1;
            //numero = numero - 3;
            //Console.WriteLine(numero);

            //int numero = 15;     //imcremento o decremento
            // numero += 1;
            //numero  -=3;

            //numero++;
            //numero--;


            //--------------------

            int valore1 = 14;
            float valore2 = 3.3f;

            float rapporto = valore1 / valore2;

                Console.WriteLine(rapporto);

            int risultato = (int)rapporto;
            Console.WriteLine(risultato);
        }
    }
}
