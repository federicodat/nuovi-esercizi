using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez02_05_classi_e_oggetti.classes
{
    internal class automobile
    {
        public string? modello;
        public string? colore;
        public int? cilindrata;

        public void Stampadettaglio()

            {
            Console.WriteLine($"modello: {modello} colore: {colore} cilindrata: {cilindrata} ");
        }
    }
}
