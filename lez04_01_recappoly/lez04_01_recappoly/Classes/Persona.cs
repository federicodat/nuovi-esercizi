using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_01_recappoly.Classes
{
    internal abstract class Persona
    {
        public string?  Nome  { get; set; }
        public string?  Cognome  { get; set; }
        public string?  CodFis  { get; set; }

        public Persona() { }    
    }
}
