using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_03_statici.classes
{
    internal class Studente
    {
        //public static int Contatore { get; private set; } = 0;   //attributo di classe
        public static int contatore  = 33;   //cosi è attirbuto
        //public string?  Nominativo { get; set; } 
        //public string?  Matricola { get; set; } 
        //public Studente() 
        //  {
        //    Contatore++;
        //}

        public static int getContatore()
        {
            return contatore;
        }
    }
}
