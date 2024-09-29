using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_2_Gestione_lista_studenti.classes
{
    internal class Studenti
    {
        public string? Nome  { get; set; } 
        public string? Cognome  { get; set; } 
        public double Voto  { get; set; } 
         
        public Studenti() { }
        public Studenti(string varNome, string varCognome, double varVoto)
        {
            Nome = varNome;
            Cognome = varCognome;
            Voto = varVoto;
            
        }

        public override string ToString()
        {
            return $"[Studenti] {Nome} {Cognome} {Voto} ";
        }
        //public List Elenco <Studenti>  =
       // public static List<Studenti> Elenco { get; set; }; //= new List<Studenti>();

        

    }
}
