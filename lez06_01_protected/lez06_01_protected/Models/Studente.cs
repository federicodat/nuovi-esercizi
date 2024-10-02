using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez06_01_protected.Models
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public Studente(string varNome, string varCognome, string varMatricola)
        {
            Matricola = varMatricola;
            Nome =varNome;
            Cognome =varCognome;
            Titolo = "stud  ";
        }   
    }
}
