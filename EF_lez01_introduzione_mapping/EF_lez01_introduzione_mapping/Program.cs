using Azure;
using EF_lez01_introduzione_mapping.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace EF_lez01_introduzione_mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            //Libro libro = new Libro();

            // Libro lbuno = new Libro()

            // { Titolo ="mandala",
            //         Autore="giovanni",
            //         Editore="pazzo",
            //         Pagine=122,
            //         Isbn="89898989898"         

            // };
            // Libro lbdue = new Libro()

            // {
            //     Titolo = "eccolo",
            //     Autore = "federi",
            //     Editore = "pazzo",
            //     Pagine = 333,
            //     Isbn = "767676767676"

            // };
            // //ctx sarebbe il context

            // using(var ctx  = new DbLez02LibreriaContext())
            // {
            //     try
            //     {
            //         ctx.Libros.Add(lbuno);
            //         ctx.Libros.Add(lbdue);
            //         ctx.SaveChanges();  


            //         Console.WriteLine("inserimento ok");

            //     } catch (Exception ex) 
            //     {
            //         Console.WriteLine("inserimento ko");

            //     }

            // }
            //-----------------------------------------

            //IList<Libro> elenco   = new List<Libro>();

            using (var ctx = new DbLez02LibreriaContext())

            {
                //ICollection<Libro> elenco = ctx.Libros.ToList();


                //foreach (Libro l in elenco)
                //{

                //    Console.WriteLine(l);
                // }
                // }
            
                // }
                try
                {
                    Libro lib = ctx.Libros.Single(l =>  l.Isbn.Equals("767676767676"));
                Console.WriteLine(lib);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("inserimento ko");

                }
                /// oppure invece si utilizza questa
                Libro? lib2 = ctx.Libros.FirstOrDefault (l => l.Isbn.Equals("76764446767676"));
                
                Console.WriteLine(lib2);
            }
            }
    }
}
