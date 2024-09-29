using Azure;
using System;
using System.Collections.Generic;

namespace Esercizio_gestione_libreria.Models;

public partial class Libri
{
    public int LibroId { get; set; }

    public string Id { get; set; } = null!;

    public string Titolo { get; set; } = null!;

    public decimal Anno { get; set; }

    public bool Disponibilita { get; set; }

    public virtual ICollection<Prestiti> Prestitis { get; set; } = new List<Prestiti>();
 
    public override string ToString()
    {
        return $"[Libro] titolo: {Titolo} anno :  {Anno} disponibilità : {Disponibilita}   ";
    }
}
