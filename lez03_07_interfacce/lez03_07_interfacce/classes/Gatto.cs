using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_07_interfacce.classes
{
    internal class Gatto :IAnimale
    {
        public bool Haspelo { get; set; }   
        public string? Colore { get; set; }

        public string? NumZampe { get; set; }

        public void TipoMovimento()
        {
            Console.WriteLine("cammina");
        }

        public void VersoEmesso()
        {
            Console.WriteLine("miaoooooo");
        }
    }
}
