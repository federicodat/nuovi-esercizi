using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez06_01_protected.Models
{
    internal class Persona
    {
        public string?  Nome { get; set; }
        public string?  Cognome { get; set; }
        public  string?  Titolo { get; private set; }
    }
}
