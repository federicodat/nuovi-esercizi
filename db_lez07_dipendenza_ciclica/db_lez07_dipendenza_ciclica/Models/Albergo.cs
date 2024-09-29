using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez07_dipendenza_ciclica.Models
{
    internal class Albergo
    {
        public string Nome { get; set; } = null!;
        public string Indirizzo { get; set; } = null!;
        public int Stelle { get; set; } = 1;

        public List<Camera>? Camere { get; set; }

        public void AggiungiCamera (Camera cam)
        {  
            if (Camere is null) 
                Camere = new List<Camera> ();

                Camere.Add (cam);

            Console.WriteLine("camera aggiunta");
        
        }
        public string Stampadettaglio()
        {

            return $"[ALBERGO] {Nome}{Indirizzo}{Stelle} ";
        }
        public override string ToString()
        {
            string camerestring = "";
            if (Camere is not null)
                foreach (Camera cam in Camere) 
                {
                    camerestring += cam.StringaDettaglio();
                }
            return $"[ALBERGO] {Nome}{Indirizzo}{Stelle}Elenco:[{camerestring}]";
        }
       
    }

}
