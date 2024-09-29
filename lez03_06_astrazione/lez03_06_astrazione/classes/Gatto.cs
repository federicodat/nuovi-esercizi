using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_06_astrazione.classes
{
    internal class Gatto : Animale
    {
        public string colore { get; set; }

        public override void VersoEmesso()
        {
            Console.WriteLine("miao");
        }
    }
}
