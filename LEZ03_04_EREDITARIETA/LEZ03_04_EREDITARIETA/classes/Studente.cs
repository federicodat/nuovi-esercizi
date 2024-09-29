using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEZ03_04_EREDITARIETA.classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public void StampaDettaglio()
        {
            Console.WriteLine($"[Persona] {Nome} {Cognome} {Matricola}");


        }
    }
}
