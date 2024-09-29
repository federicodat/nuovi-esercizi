using Lez03_08_Task.classes;
using System.Drawing;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

/*
 * Creare un sistema di gestione veicoli:
* 
* All'inserimento di un nuovo veicolo mi sarà permessa la scelta tra:
* 1. Automobile
* 2. Moto
* 
* Alla fine dell'inserimento delle caratteristiche del veicolo, stampare i suo dettagli.
* 
* Libera scelta degli attributi.
*/


bool insAbi = true;
List<string> Elenco = new List<string>();

while (insAbi)
{
    Console.Write("Dimmi cosa vuoi fare:\n +" +
        "I per inserimento \n +" +
        "Q per uscire");

    string? inputUtente = Console.ReadLine();

    if (inputUtente != null) inputUtente = inputUtente.ToUpper();

    switch (inputUtente)
    {
        case "I":
            Console.WriteLine("veicolo A-auto, M-Moto:");
            string? vartipo = Console.ReadLine();

            if (vartipo is not null && !vartipo.Trim().Equals(""))
            {
                switch (vartipo)
                {
                    case "M":
                        Console.WriteLine("targa");
                        string? varTarga = Console.ReadLine();
                        Console.WriteLine("colore");
                        string? varColore = Console.ReadLine();
                        Console.WriteLine("marca");
                        string? varMarca = Console.ReadLine();
                        Console.WriteLine("modello");
                        string? varModello = Console.ReadLine();

                        Console.WriteLine("hai sidecar s/n?");
                        string? varSidecar = Console.ReadLine();
                        bool valoreSidecar = false; 
                         
                        if (varSidecar is not null && varSidecar.Equals("Y"))
                            valoreSidecar = true;

                        Console.WriteLine("hai bauletto s/n?");
                        string? varBauletto = Console.ReadLine();
                        bool valoreBauletto = false;
                         
                        if (varBauletto is not null && varBauletto.Equals("Y"))
                            valoreBauletto = true;




                        Moto mot = new Moto()
                        {
                            Colore = varColore,
                            Targa = varTarga,
                            Marca = varMarca,
                            Modello = varModello,
                            Sidecar = valoreSidecar,
                            Bauletto= valoreBauletto

                        };



                        mot.StampaDettaglio();
                        // Moto.add()
                        break;
                    case "A":
                        Console.WriteLine("targa");
                        string? varTargaa= Console.ReadLine();
                        Console.WriteLine("colore");
                        string? varColorea= Console.ReadLine();
                        Console.WriteLine("marca");
                        string? varMarcaa= Console.ReadLine();
                        Console.WriteLine("modello");
                        string? varModelloa= Console.ReadLine();
                        Console.WriteLine("porte");
                        string? varPorte= Console.ReadLine();
                        Console.WriteLine("posti");
                        int? varPosti= Convert.ToInt32(Console.ReadLine());

                        
                        Auto aut = new Auto() { 
                            Colore =varColorea ,
                            Targa = varTargaa ,
                            Marca = varMarcaa ,
                            Modello = varModelloa,
                            Porte = varPorte ,
                            Posti = varPosti
                        
                        
                        
                        };


                        Auto..StampaDettaglio();
                        // Auto.add()
                        break;
                    default:
                        Console.WriteLine("tipo non previsto");
                        break;
                }
            }
            else
                Console.WriteLine("non accetto vuoto");

            break;




        case "Q":
            insAbi = !insAbi;
            break;

        default:
            Console.WriteLine("comando errato");
            break;
    }

    //Console.WriteLine($"elenco invitati:\n{Elenco}");




}
//for (int i = 0; i < Lista.Count; i++) { 

//    Console.WriteLine(Lista[i]);


//}






Console.WriteLine("Hello, World!");
