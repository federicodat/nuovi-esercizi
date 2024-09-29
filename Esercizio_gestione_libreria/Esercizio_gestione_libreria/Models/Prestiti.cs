using System;
using System.Collections.Generic;

namespace Esercizio_gestione_libreria.Models;

public partial class Prestiti
{
    internal string nominativo1;
    internal string librotit;
    internal string nominativo2;
    internal DateTime dataprest;
    internal DateTime dataritor;

    public int PrestitoId { get; set; }

    public string Id { get; set; } = null!;

    public DateOnly DataPrestito { get; set; }

    public DateOnly? DataRitorno { get; set; }

    public int UtenteRif { get; set; }

    public int LibroRif { get; set; }

    public virtual Libri LibroRifNavigation { get; set; } = null!;

    public virtual Utenti UtenteRifNavigation { get; set; } = null!;

    public virtual ICollection<Utenti> Nome { get; set; } = new List<Utenti>();
    public override string ToString()
    {
        return $"[prestiti]utente : {nominativo1}  {nominativo2}   libro :{librotit} data prestito :{dataprest}  data:rientro: {dataritor}  ";
        //return $"[prestiti]utente : {UtenteRifNavigation.Cognome} libro :{LibroRifNavigation} data prestito :{DataPrestito} data:rientro: {DataRitorno}  ";
    }

}
 
