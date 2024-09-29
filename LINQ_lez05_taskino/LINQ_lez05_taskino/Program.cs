using LINQ_lez05_taskino.Models;
using System.Runtime.ConstrainedExecution;

namespace LINQ_lez05_taskino

{  
      /*        Creare una lista di prodotti caratterizzati da:
                - Nome
                - Descrizione
                - Prezzo
                - Categoria
                - Quantità
 
                Inserire un numero n di prodotti:
                - Mandare in output tutti i prodotti di una certa categoria
                - Calcolare il prezzo medio dei prodotti
                - Riepilogare le quantità numeriche per categoria di prodotto
                - Creare un report del valore del negozio calcolato come "quantità x prezzo" di ogni prodotto   
            */
    internal class Program
    {
        

        static void Main(string[] args)
        {

            List<Prodotto> elenco = new() {
            new Prodotto("Penna A", "penna stilo",10f , "Cancelleria", 10),
            new Prodotto("Penna b", "penna biro",5f , "Cancelleria", 20),
            new Prodotto("Penna c", "penna magica",22f , "Cancelleria", 10),
            new Prodotto("gomma A", "gomma arabi ",3f , "Cancelleria", 33),
            new Prodotto("gomma b", "gomma stilo",10f , "Cancelleria", 10),
            new Prodotto("banco A", "banco stilo",55f , "Mobili", 10),
            new Prodotto("banco b", "banco old",66f , "Mobili", 10)
             };
            //Mandare in output tutti i prodotti di una certa categoria
            //querylike
            //var risultato = from prodotto in elenco
            //                where prodotto.Categoria is not null && prodotto.Categoria.Equals("Cancelleria")
            //                select prodotto;
            //function like
            var risultato = elenco.Where(p => p.Categoria.Equals("Cancelleria"));


            foreach (var cat in risultato)
                        {
                          Console.WriteLine(cat);   
                                                 
                        }
            //onsole.WriteLine("Hello, World!");

            //-Calcolare il prezzo medio dei prodotti

            var prezzi = elenco.Select(p => p.Prezzo);
            float somma = 0;
            
                
            foreach (var p in prezzi)
            {
                somma = somma + p;
                Console.WriteLine(somma/ prezzi.Count());

            }



            var prezz2 = from p in elenco
                         select p.Prezzo;
            float media = prezz2.Average();

             Console.WriteLine(somma / prezz2.Count());

            var risultatoa = elenco.Average(p => p.Prezzo);

                Console.WriteLine(risultatoa);

            //------------------------------------------
            //             -Riepilogare le quantità numeriche per categoria di prodotto

            Console.WriteLine("----riepilogare le quantità numeriche per categoria di prodotto-------------------");

            var raggruppamenti  = from prodotto in elenco
                             group prodotto by prodotto.Categoria into contenitoriCategoria
                             select contenitoriCategoria;
            foreach (var gruppo in raggruppamenti)
            {
                Console.WriteLine($"Categoria : {gruppo.Key} ");
                float somma = gruppo.Sum(p => p.Quantita);
                Console.WriteLine(somma);
                //foreach (var r in cate)
                //{
                   
                //    Console.WriteLine(quantita.Sum());

                //}


                Console.WriteLine(cate);


            }
        }
    }
}
