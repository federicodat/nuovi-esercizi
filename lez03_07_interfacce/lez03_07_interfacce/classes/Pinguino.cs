using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_07_interfacce.classes
{
    internal class Pinguino : IAnimale
    {
        public string? Colore { get; set; }

        public void TipoMovimento()
        {
            Console.WriteLine("ciondola");
        }

        public void VersoEmesso()
        {
            Console.WriteLine("bleeeeee");
        }
    }
}
