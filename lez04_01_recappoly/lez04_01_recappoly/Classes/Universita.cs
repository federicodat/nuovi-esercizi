using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lez04_01_recappoly.Classes
{
    internal class Universita
    {
        public string?  Nome  { get; set; }
        public string?  Indirizzo  { get; set; }

        public List<Persona>  Elenco  { get; set; } = new List<Persona>();  //aggregazione  costruzione elenco vuoto

        public void AggiungiStudente(Studente objStu)
        {
            Elenco.Add(objStu);
            Console.WriteLine("studente inserito");
        }

        public void AggiungiDocente (Docente objDoc)
        {
            Elenco.Add(objDoc);
            Console.WriteLine("docente  inserito");
        }
#region stampaini
        public void StampaTutti ( )
        {
            foreach (Persona per in Elenco)
                //Console.WriteLine("lista inserito");
                Console.WriteLine(per.ToString());


        }
        //stampa per tipologia
        public void StampaStudenti()
        {
            foreach (Persona per in Elenco)
            { if (per.GetType() == typeof(Studente))
                Console.WriteLine(per.ToString());

                         }

        }


        public void StampaDocenti()
        {
            foreach (Persona per in Elenco)
            {
             

                if (per.GetType() == typeof(Docente))
                    Console.WriteLine(per.ToString());
            }

        }

        public void StampaCertificatiStudenti()
        {
            foreach (Persona per in Elenco)
            {


                if (per.GetType() == typeof(Studente))
                {
                    Studente stu = (Studente)per;
                    stu.StampaCartaInt();

                }
            }

        }


        #endregion stampaini
    }
}
