using Esercizio_2_Gestione_lista_studenti.classes;

namespace Esercizio_2_Gestione_lista_studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool insAbi = true;

         

            double varVoto = 0;




            #region menu 
            List<string> elenco  = new List<string>() ;

            while (insAbi)
            {
                Console.Write("Dimmi cosa vuoi fare: \n - " +
                    "A Aggiungere uno studente alla lista \n - " +
                    "M Modificare i dati di uno studente esistente \n - " +
                    "V Visualizzare l’elenco completo degli studenti \n - " +
                    "F Filtrare gli studenti in base a un voto minimo e massimo \n - " +
                    "E Eliminare uno studente dalla lista in base al nome. \n - " +
                    "Q per uscire   : ");

                string? inputUtente = Console.ReadLine();

               // List<Studenti> elenco = new List<Studenti>();
                if (inputUtente != null) inputUtente = inputUtente.ToUpper();

                try
                {
                    switch (inputUtente)
                    {
                        case "A":
                            {
                               Console.WriteLine("Inserisci Nome: ");
                                string? varnome = Console.ReadLine();
                                 
                                    if (varnome is not null && !varnome.Trim().Equals(""))
                                         { 
                                            Console.WriteLine("Inserisci Cognome: ");
                                            string? varcognome = Console.ReadLine();
                                            if (varcognome is not null && !varcognome.Trim().Equals(""))

                                              { Console.WriteLine("Inserisci  : ");

                                                Studenti stu = new Studenti()
                                                     {
                                                        Nome = varnome,
                                                        Cognome = varcognome,
                                                        Voto = varVoto
                                                      }; 
                                               elenco.Add( varnome + " " + varcognome);
                                        Console.WriteLine("inserito");
                                                }

                                    else
                                        Console.WriteLine("non accetto vuoto");
                                        }
                                else
                                    Console.WriteLine("non accetto vuoto");
                                
                               
                                //break;
                            }

                            //    double varcifra1 = Convert.ToDouble(Console.ReadLine());
                            //    Console.WriteLine("Addizione : dammi cifra 2: "); ;
                            //    double varcifra2 = Convert.ToDouble(Console.ReadLine());

                            //    double somma = varcifra1 + varcifra2;

                            //Console.WriteLine($"Risultato operazione:{Nome}  ");
                                Console.WriteLine("Aggiungere uno studente alla lista");
                                break;

                            
                        case "M":
                            {
                                 
                                Console.WriteLine("modifica uno studente alla lista");
                                break;

                            }  
                        case "V":
                            {
                                 
                                Console.WriteLine("Visualizzare l’elenco completo degli studenti");
                                for (int i = 0; i < elenco.Count; i++)
                                {

                                       Console.WriteLine(elenco[i]);


                                     }

                                }
                                break;
                        case "F":
                            {
                                 
                                Console.WriteLine("Filtrare gli studenti in base a un voto minimo e massimo");
                                break;

                            }
                            case "E":
                            {
                                 
                                Console.WriteLine("Eliminare uno studente dalla lista in base al nome");
                                break;

                            }


                        case "Q":
                            insAbi = !insAbi;
                            break;

                        default:
                            Console.WriteLine("comando errato");
                            break;
                            #endregion menu 

                    }
                }




                catch (FormatException)
                {

                    Console.WriteLine("cifra  deve essere numerica");
                }
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}
