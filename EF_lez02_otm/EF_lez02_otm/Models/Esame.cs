using System;
using System.Collections.Generic;

namespace EF_lez02_otm.Models;

public partial class Esame
{
    public int EsameId { get; set; }

    public string Titolo { get; set; } = null!;

    public DateTime DataEsame { get; set; }

    public int? Crediti { get; set; }
}
