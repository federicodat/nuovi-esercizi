using lez04_01_recappoly.Classes;

namespace lez04_01_recappoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di gestione scolastica dove le informazioni di cui abbiamo bisogno sono:
             * - Studente
             * - Docente
             */

            //Persona gio = new Studente("Giovanni", "Pace", "PCAGNN", "AB1234", "Informatica");
            //Persona val = new Studente("Valeria", "Verdi", "VLRVRD", "AB1235", "Ingegneria");

            //Persona doc  = new Docente("marika", "rossi", "RRRRR", "ACC235",  true);

            //List<Persona> elenco = new List<Persona>();
            //elenco.Add(gio);
            //elenco.Add(val);
            //elenco.Add(doc);

            //foreach (Persona per in elenco) 
            //{   
            //    if (per.GetType() == typeof(Studente))
            //     { Studente stu = (Studente)per;
            //        stu.StampaCartaInt();

            //        // Console.WriteLine(per.ToString()); 
            //    }
            //    if (per.GetType() == typeof(Docente))
            //    {
            //        Docente dd = (Docente)per;
            //        dd.DettaglioDocente();

            // Console.WriteLine(per.ToString()); 

    //    }
    //}

    //----------------------composizione

    Studente gio = new Studente("Giovanni", "Pace", "PCAGNN", "AB1234", "Informatica");
                    Studente val = new Studente("Valeria", "Verdi", "VLRVRD", "AB1235", "Ingegneria");

                    Docente doc = new Docente("marika", "rossi", "RRRRR", "ACC235", true);


                    Universita accademi = new Universita();
                    accademi.AggiungiStudente(gio);
                    accademi.AggiungiStudente(val);
                    accademi.AggiungiDocente(doc);

            accademi.StampaTutti();
            accademi.StampaStudenti();



        }
    }
}
