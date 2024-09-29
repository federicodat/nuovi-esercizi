using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_06_astrazione.classes
{
    internal abstract class Animale   //abstract non permette la new
    {
        public bool haspelo { get; set; }
        public bool NumZampe { get; set; }
        public bool Vola { get; set; }

        public abstract void VersoEmesso();

        //{          
        //}
    }
}
