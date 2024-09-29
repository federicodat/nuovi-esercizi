using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez08_injection.Models
{
    internal class Utente
    {
        public int Id { get; set; }
        public int Username { get; set; } = null!;
        public int Password { get; set; } = null!;

        public int Ruolo { get; set; } = null!;

        public string StringaDettaglio()
        {
            return $"[CAMERA] {Codice}   {Posti} {Descrizione}             ";
        }
    }
}
