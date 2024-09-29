using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_09_poli.classes
{
    internal class Moto : Veicolo
    {
        public bool Sidecar { get; set; } = false;
        public bool Bauletto { get; set; } = false;

        public override void StampaDettaglio()
       
        {
            Console.WriteLine($"[Moto] {Targa}{Colore} {Modello} {Marca} {Sidecar} {Bauletto}");
        }

        // public override void StampaDettaglio()

        //public override void Accensione()

        //{
        //    Veicolo.A
        //}

    }
}
