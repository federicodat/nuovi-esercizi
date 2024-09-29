using EF_lez02_otm.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;

namespace EF_lez02_otm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persona osv = new Persona(){ Nome = "osvaldo", Cognome = "bebi", Email = "rrr@tt" } ;

            Cartum caruno = new Cartum() { Codice = "cc6666", Negozio = "coin", PersonaRifNavigation = osv };
            Cartum cardue = new Cartum() { Codice = "rr4444", Negozio = "tt", PersonaRifNavigation = osv };
            using (var ctx = new Lez06OtmCarteContext())
                
            {
                try

                {
                    ctx.Personas.Add(osv);
                    ctx.Carta.Add(caruno);
                    ctx.Carta.Add(cardue);
                    ctx.SaveChanges();


                    Console.WriteLine("inserimento ok");
                } catch (Exception ex)
                 {
                  Console.WriteLine("inserimento ko");

                 }
         }

        ////-------------------------------

        //using (var ctx = new Lez06OtmCarteContext())
        //{
        //    var elCarte = ctx.Carta.ToList();
        //    foreach (var car in elCarte)
        //    {
        //        car.PersonaRifNavigation = ctx.Personas.Single(p => p.PersonaId == car.PersonaRif);

        //        Console.WriteLine(car);
        //    }
        //}
        //----per il momento no uso riferimenti
        //----------------------
        //using (var ctx = new Lez06OtmCarteContext())
        //{try
        //    {
        //        Persona? gio = ctx.Personas.FirstOrDefault
        //        (p => p.Email == "gio@pace.com");

        //        Console.WriteLine(gio);
        //    }catch (Exception ex) {
        //        Console.WriteLine("errore");



        //    }
        //}
        //------------------------------

    }
    }
}
