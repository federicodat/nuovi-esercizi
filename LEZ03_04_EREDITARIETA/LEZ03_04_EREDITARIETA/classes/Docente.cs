using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEZ03_04_EREDITARIETA.classes
{
    internal class Docente
    {
        public string? Dipartimento { get; set; }
        public override void StampaDettaglio()
        {
            Console.WriteLine($"[Persona] {Nome} {Cognome}");


        }
    }
}
