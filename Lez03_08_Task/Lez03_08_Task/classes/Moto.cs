﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_08_Task.classes
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



    }
}
