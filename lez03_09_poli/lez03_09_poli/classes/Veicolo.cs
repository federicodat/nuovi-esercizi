using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_09_poli.classes
{
    internal abstract class Veicolo
    {
         
            public string Colore { get; set; }
            public string Marca { get; set; }
            public string Modello { get; set; }

            public string Targa { get; set; }

        public Veicolo() { }    
        public  virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Veicolo] {Targa}{Colore} {Modello} {Marca} ");
        }

        public virtual void Accensione()
        {
            Console.WriteLine("");
        }

    }
}
