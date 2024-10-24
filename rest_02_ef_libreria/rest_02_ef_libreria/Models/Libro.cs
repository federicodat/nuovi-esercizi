using System;
using System.Collections.Generic;

namespace rest_02_ef_libreria.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string Codice { get; set; } = Guid.NewGuid().ToString();

    public string Titolo { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string Autore { get; set; } = null!;

    public decimal Prezzo { get; set; }

    public int Quantita { get; set; }
}
