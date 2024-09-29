using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lez04_01_recappoly.Classes
{
    internal class Studente :   Persona
    {
        public string?  Matricola  { get; set; }
        public string?  Corso  { get; set; }


        //public Studente(string varNome, string varCognome, string varCodFis, string varMatricola, string varCorso);
        public override string ToString()
        {
            return $"[Studente] {Nome} {Cognome} {CodFis}   {Matricola } {Corso} ";
         
        }
        public Studente(string varNome, string varCognome, string varCodFis, string varMatricola, string varCorso)
         {
            Nome = varNome;
            Cognome = varCognome;
            CodFis = varCodFis;
            Matricola = varMatricola;
            Corso = varCorso;
         
        }
    public void StampaCartaInt()
        {
            Console.WriteLine("-------------------- *** -------------------");
            Console.WriteLine($" Lo studente: {Nome} {Cognome}");
            Console.WriteLine($" Iscritto al corso di: {Corso}");
            Console.WriteLine("-------------------- *** -------------------");
        }
   
    }
}
