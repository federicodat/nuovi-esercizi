using System;
using System.Collections.Generic;

namespace EF_lez02_otm.Models;

public partial class StudenteEsame
{
    public int StudenteRif { get; set; }

    public int EsameRif { get; set; }

    public virtual Esame EsameRifNavigation { get; set; } = null!;

    public virtual Studente StudenteRifNavigation { get; set; } = null!;
}
