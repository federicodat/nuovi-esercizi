using System;
using System.Collections.Generic;

namespace rest04_ef_videoteca.Models;

public partial class Supporto
{
    public int SupportoId { get; set; }

    public string Codice { get; set; } = null!;

    public string Titolo { get; set; } = null!;

    public int? Anno { get; set; }

    public bool? Disponibilita { get; set; }

    public string Tipo { get; set; } = null!;

    public int VideotecaRif { get; set; }

    public virtual Videoteca VideotecaRifNavigation { get; set; } = null!;
}
