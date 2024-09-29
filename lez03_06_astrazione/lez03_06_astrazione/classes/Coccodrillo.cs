using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_06_astrazione.classes
{
    internal class Coccodrillo : Animale
    {
    public  bool hasSquame { get; set; }

        public override void VersoEmesso()
        {
             
            Console.WriteLine("nessuno lo sa");
        }
    }
}
