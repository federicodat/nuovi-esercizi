using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_02_composizioni.classes
{
    internal class Mazzo
    {
        public bool HasFiocco { get; set; } =true;
        public List <Fiore>? Lista { get; set; } =null;  //metter ? se null

        public void AggiungiFiore(Fiore objFio)
            { 
            if (Lista is null)
                Lista = new List<Fiore> (); 

            Lista.Add(objFio);
        
        } 
    }
}
