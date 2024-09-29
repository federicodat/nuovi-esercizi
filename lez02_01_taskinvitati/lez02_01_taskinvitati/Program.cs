namespace lez02_01_taskinvitati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            /* 
           * Scrivere un sistema di gestione invitati alla propria festa
           * L'inserimento avviene tramite console e prende in input, in tre tempi diversi,
           * il nome, il cognome ed il numero di telefono.
           * 
           * All'uscita del programma verrà stampato l'elenco delle persone precedentemente inserite separato da virgola.
           *
           *TIP: Crea una stringa all'inizio del programma che ti potrà essere utile per aggiungere gli invitati.
           */
            string? nome;
            //string? cognome  ;
            //string? telefono ;

            bool insabi = true;
            string? elencoinvitati = "";
            while (insabi)
                
            {
                Console.Write("dimmi cosa vuoi fare : \nI-inserimento \nQ-uscita  ");
                string? inputdato = Console.ReadLine();
                if (inputdato is not null)
                    inputdato = inputdato.ToUpper();
                 
                switch (inputdato)
                {
                    case "I":
                        //inserimenti
                        Console.WriteLine("dammi il nome:");
                        string? inNome = Console.ReadLine();
                        Console.WriteLine("dammi il cognome:");
                        string? incognome = Console.ReadLine();
                        Console.WriteLine("dammi il telefono:");
                        string? intel = Console.ReadLine();
                        elencoinvitati += $"{inNome} {incognome} {intel}";
                        Console.WriteLine("inserimento riuscito");

                        break;

                    case "Q":
                        insabi = !insabi;
                        break;
                    default:
                        Console.WriteLine("comando non risonosciuto");
                        break;

                }
                Console.WriteLine($"Elenco invitati il telefono:\n{elencoinvitati}");
            }
            //-----------------------------
            //end
        }
    }
    
}
