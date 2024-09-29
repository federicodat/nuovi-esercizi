
using Esercizio_gestione_libreria.Models.DAL;
using Esercizio_gestione_libreria.Models;
using System.ComponentModel.Design;
using Azure;

namespace Esercizio_gestione_libreria
{
    internal class Program
    {
         

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            bool insAbi = true;

            while (insAbi)
            {
                Console.WriteLine("Scegli la tua operazione:\n" +
                    "U - lista utenti   \n" +
                    "L - lista Libri \n" +
                    "P - lista prestiti \n" +
                    "I - Inserisci Libro \n" +
                    "B - modifica Libro \n" +
                    "T - Cancella Libro \n" +
                    "W - Inserisci Utente \n" +
                    "Y - modifica Utente \n" +
                    "D - cancella Utente \n" +
                    "S - cancella Prestito \n" +
                    "G - effettua Prestito \n" +
                    "H - restituisci Prestito \n" +
                    "R - Ricerca libri disponibili \n" +
                    "O - Ricerca  prestiti in corso per utente \n" +
                    "L - Ricerca  utenti con il maggior numero di prestiti attivi \n" +
                    "Q - Uscita");
                 
                string? inputUtente = Console.ReadLine().ToUpper();


                switch (inputUtente)
                {
                    case "U":
                     
                            Console.WriteLine("--------------lista utente----------------");

                        List<Utenti> elencou = UtenteDao.GetInstance().GetAll();

                        foreach (Utenti ut in elencou)
                        {
                            Console.WriteLine(ut);
                        }
                        break;

                    case "L":

                        Console.WriteLine("------------------lista libro-------------------");
                        List<Libri> elenco = LibriDAO.GetInstance().GetAll();

                        foreach (Libri libro in elenco)
                        {
                            Console.WriteLine(libro);
                        }
                        break;
                    case "P":

                        Console.WriteLine("------------------lista prestiti-------------------");
                         

                        List<Prestiti> elencop = PrestitiDAO.GetInstance().GetAll();

                        foreach (Prestiti pp in elencop)
                        {
                            Console.WriteLine(pp);
                        }
                        break;
                    case "I":

                        Console.WriteLine("--------------inserimento libro-----------------");
                        Console.WriteLine("Inserisci il titolo");
                        string? inTitolo = Console.ReadLine();
                        Console.WriteLine("Inserisci anno edizione");
                        string? intanno = Console.ReadLine();
                        if (inTitolo == null || intanno == null || inTitolo.Equals("") || intanno.Equals("") )
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }

                        
                      
                            //int? inAnno = (int)Convert.ToDecimal(Console.ReadLine());
                            int? inAnno = (int)Convert.ToDecimal(intanno);
                                
                            Libri lib = new Libri()
                            {
                            Titolo = inTitolo  ,
                            Anno = (decimal)inAnno

                            };

                            if (LibriDAO.GetInstance().Insert(lib))

                                Console.WriteLine("Libro inserito con successo");
                            else
                                Console.WriteLine("ERRORE di inserimento");

                            break;

                    case "W":

                        Console.WriteLine("--------------inserimento Utente-----------------");
                        Console.WriteLine("Inserisci il Nome");
                        string? inNome = Console.ReadLine();
                        Console.WriteLine("Inserisci il cognome");
                        string? inCognome = Console.ReadLine();
                        Console.WriteLine("Inserisci la mail");
                        string? inMail = Console.ReadLine();
                     
                        if (inNome == null || inCognome == null || inMail == null || inNome.Equals("") || inCognome.Equals("") || inMail.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }

                        Utenti utt = new Utenti()
                        {
                            Nome = inNome,
                            Cognome = inCognome,
                            Email = inMail

                        };

                        if (UtenteDao.GetInstance().Insert(utt))

                            Console.WriteLine("Utente inserito con successo");
                        else
                            Console.WriteLine("ERRORE di inserimento");

                        break;

                    case "Y":

                        Console.WriteLine("--------------modifica Utente-----------------");
                        Console.WriteLine("Inserisci identificativo");
                        string? inID = Console.ReadLine();
                        

                        if (inID == null || inID.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }

                        Console.WriteLine("Inserisci il Nome");
                        string? inNomen = Console.ReadLine();
                        Console.WriteLine("Inserisci il cognome");
                        string? inCognomen = Console.ReadLine();
                        Console.WriteLine("Inserisci la mail");
                        string? inMailn = Console.ReadLine();

                        if (inNomen == null || inCognomen == null || inMailn == null || inNomen.Equals("") || inCognomen.Equals("") || inMailn.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }
                        
                            Utenti uttn = new Utenti()
                        {
                                Id = inID,
                                Nome = inNomen,
                            Cognome = inCognomen,
                            Email = inMailn

                        };

                        if (UtenteDao.GetInstance().Update(uttn))

                            Console.WriteLine("Utente modificato con successo");
                        else
                            Console.WriteLine("non trovato o errore d ");

                        break;
                    case "D":

                        Console.WriteLine("--------------cancella Utente-----------------");
                        Console.WriteLine("Inserisci identificativo");
                        string? inIDd = Console.ReadLine();


                        if (inIDd == null || inIDd.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }


                        Utenti uttd = new Utenti()
                        {
                            Id = inIDd
                             

                        };

                        if (UtenteDao.GetInstance().Delete(uttd))

                            Console.WriteLine("Utente cancellato con successo");
                        else
                            Console.WriteLine("non trovato   ");

                        break;
                    case "T":

                        Console.WriteLine("--------------cancella libro-----------------");
                        Console.WriteLine("Inserisci identificativo");
                        string? inIDld = Console.ReadLine();


                        if (inIDld == null || inIDld.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }


                        Libri libd = new Libri()
                        {
                            Id = inIDld


                        };

                        if (LibriDAO.GetInstance().Delete(libd))

                            Console.WriteLine("libro cancellato con successo");
                        else
                            Console.WriteLine("non trovato   ");

                        break;
                    case "S":

                        Console.WriteLine("--------------cancella prestito-----------------");
                        Console.WriteLine("Inserisci identificativo");
                        string? inIDpd = Console.ReadLine();


                        if (inIDpd == null || inIDpd.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }


                        Prestiti pred = new Prestiti()
                        {
                            Id = inIDpd


                        };

                        if (PrestitiDAO.GetInstance().Delete(pred))

                            Console.WriteLine("prestito cancellato con successo");
                        else
                            Console.WriteLine("non trovato   ");
 

                        break;
                    case "B":

                        Console.WriteLine("--------------modifica Libro-----------------");
                        Console.WriteLine("Inserisci identificativo");
                        string? inID3 = Console.ReadLine();


                        if (inID3 == null || inID3.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }

                        Console.WriteLine("Inserisci il titolo");
                        string? intitolo = Console.ReadLine();
                        Console.WriteLine("Inserisci anno");
                        string? intanno2 = Console.ReadLine();
                        

                        if (intitolo == null || intanno2 == null ||   intitolo.Equals("") || intanno2.Equals("")  )
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }

                        int? inAnno2 = (int)Convert.ToDecimal(intanno2);

                      
                        Libri lib3 = new Libri()
                        {
                            Id = inID3,
                            Titolo = intitolo,
                            Anno = (decimal)inAnno2


                        };

                        if (LibriDAO.GetInstance().Update(lib3))

                            Console.WriteLine("Libro modificato con successo");
                        else
                            Console.WriteLine("non trovato o errore d ");

                        break;

                
                    case "G":

                        Console.WriteLine("--------------EFFETTUA prestito-----------------");
                        Console.WriteLine("Inserisci identificativo libro");
                        string? inIDpde = Console.ReadLine();
                        

                        if (inIDpde == null || inIDpde.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }
                       

                        if (LibriDAO.GetInstance().GetById(inIDpde))
                             
                            Console.WriteLine("Inserisci identificativo Utente");
                            string? inIDute = Console.ReadLine();


                            if (inIDute == null || inIDute.Equals(""))
                            {
                                Console.WriteLine("dati non validi  ");
                                break;
                            }
                             UtenteDao.GetInstance().GetById(inIDute);
                             
                      
                        

                            Prestiti inpre = new Prestiti()
                             {
                                 
                                    UtenteRif = UtenteDao.uteid,
                                    LibroRif = LibriDAO.libid

                            };

                        if (PrestitiDAO.GetInstance().Insert(inpre))

                           Console.WriteLine("prestito inserito con successo");


                        Libri obj = new Libri()
                        {

                            Disponibilita = false,
                            Id= inIDpde

                        };
                        LibriDAO.GetInstance().Updatedisp(obj);

                        //else
                        //    Console.WriteLine("non trovato   ");

                        break;
                    case "H":

                        Console.WriteLine("--------------restituisci prestito-----------------");
                        Console.WriteLine("Inserisci identificativo");
                        
                        
                        string? inIDpdr = Console.ReadLine();


                        if (inIDpdr == null || inIDpdr.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }


                        Prestiti prer = new Prestiti()
                        {
                            Id = inIDpdr
                        };

                        if (PrestitiDAO.GetInstance().GetById(prer))

                            if (prer.DataRitorno is not null )
                              
                               if (PrestitiDAO.GetInstance().Update(prer))
                                     Console.WriteLine("prestito restituito con successo");
 

                        break;
                    case "R":

                        Console.WriteLine("--------------libri disponibili per il prestito -----------------");


                        using (var ctx = new EsercizioGestioneLibreriaContext())
                        {
                            try
                            {

                                var libriDisponibili = ctx.Libris.Where(e => e.Disponibilita == true).ToList();

                                foreach (Libri l in libriDisponibili) 
                                {
                                      Console.WriteLine(l);
                                   }                 
                             }


                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                        }

                        

                        break;
                    case "O":

                        Console.WriteLine("--------------Ricerca  prestiti in corso per utente-----------------");
                        Console.WriteLine("Inserisci identificativo");
                        string? inIDctx = Console.ReadLine();


                        if (inIDctx == null || inIDctx.Equals(""))
                        {
                            Console.WriteLine("dati non validi  ");
                            break;
                        }


                        //using (var ctx = new EsercizioGestioneLibreriaContext())
                        //{
                        //    try
                        //    {

                        //       //var prestitiutente = ctx.Prestitis.Join(ctx.Utentis,   Prestiti.UtenteRif = Utenti.UtenteId ,  
                        //       //                                         utente => utente.UtenteID,
                        //       //    (e => e.id = inIDctx ).ToList();


 


                        //        foreach (Prestiti l in prestitiutente)
                        //        {
                        //            Console.WriteLine(l);
                        //        }
                        //    }


                        //    catch (Exception ex)
                        //    {
                        //        Console.WriteLine(ex.Message);
                        //    }

                       //}



                        break;
                    case "Q":
                        insAbi = false;
                        break;
                    default:
                        Console.WriteLine("Comando non riconosciuto");
                        break;
                }
            }
            //---------------------------------------
        }

        
    }
}
