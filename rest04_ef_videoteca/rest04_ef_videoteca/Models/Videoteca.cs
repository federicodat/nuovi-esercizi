using System;
using System.Collections.Generic;

namespace rest04_ef_videoteca.Models;

public partial class Videoteca
{
    public int VideotecaId { get; set; }

    public string Codice { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Indirizzo { get; set; }

    public virtual ICollection<Supporto> Supportos { get; set; } = new List<Supporto>();
}
