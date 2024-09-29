using System;
using System.Collections.Generic;

namespace EF_lez02_otm.Models;

public partial class Studente
{
    public int StudenteId { get; set; }

    public string Nominativo { get; set; } = null!;

    public string Matricola { get; set; } = null!;
}
