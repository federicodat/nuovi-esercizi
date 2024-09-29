using System;
using System.Collections.Generic;

namespace Esercizio_gestione_libreria.Models;

public partial class Utenti
{
    public int UtenteId { get; set; }

    public string Id { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Cognome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Prestiti> Prestitis { get; set; } = new List<Prestiti>();

    public override string ToString()
    {
        return $"[utente] nome : {Nome} cognome :  {Cognome} email : {Email}   ";
    }
}
