using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_gestione_libreria.Models.DAL
{
    internal class PrestitiDAO
    {
        public static string nominativo1 = ""; 
        public static string nominativo2 = ""; 
        public static string librotit = "";
        public static DateTime? dataritor = null;
        public static DateTime dataprest  ;
        
        //public static bool IsDBNull(DateTime? dataprest value);

        private static PrestitiDAO? instance;
        private Prestiti? pre1;
        private DateTime? datarestituzione;
        private DateTime? datarestituzion2;

        public static PrestitiDAO GetInstance()
        {
            if (instance is null)
                instance = new PrestitiDAO();

            return instance;
        }
        private PrestitiDAO()
        {

        }
        public bool Delete(Prestiti obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "Delete from Prestiti where ID=@id  ";
                cmd.Parameters.AddWithValue("@id", obj.Id);


                try
                {
                    conn.Open();

                    int affRows = cmd.ExecuteNonQuery();
                    if (affRows > 0)
                        risultato = true;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public List<Prestiti> GetAll()
        {
            
            {
                List<Prestiti> lspre = new List<Prestiti>();

                using (SqlConnection conn = new SqlConnection(Config.credenziali))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    //cmd.CommandText = "SELECT  UtenteRif, LibroRif,Data_prestito , Data_ritorno FROM Prestiti  ";
                    cmd.CommandText = "SELECT  Nome,Cognome,Titolo, Data_prestito ,  ISNULL(data_ritorno, '31/12/2999') as data_rito     FROM Prestiti  join utenti on UtenteRif=UtenteID join Libri on LibroRif= LibroId";
                    try
                    {
                        conn.Open();
                      SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())

                        {
                            Prestiti pr = new Prestiti()
                            {

                                nominativo1 = reader.GetString(0),
                                nominativo2 = reader.GetString(1),
                                librotit = reader.GetString(2),
                                dataprest = reader.GetDateTime(3) ,
                                dataritor = (DateTime)(reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4))  // Data_ritorno

                            

                            };

                            

                            lspre.Add(pr);
                        }

                        //conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }

                return lspre;
            }
        }

        //public Libri? GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}
        public Prestiti? GetById(int Id)
        {
             throw new NotImplementedException();
           
        }


        public bool Insert(Prestiti obj)

        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Prestiti( Data_prestito, Data_RITORNO, UtenteRIF, LibroRIF)  VALUES (@datp, null, @ute,@lib)";
               
                cmd.Parameters.AddWithValue("@datp", DateTime.Now);  
                cmd.Parameters.AddWithValue("@ute", obj.UtenteRif);
                cmd.Parameters.AddWithValue("@lib", obj.LibroRif);


                try
                {
                    conn.Open();

                    int affRows = cmd.ExecuteNonQuery();
                    if (affRows > 0)
                        risultato = true;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public bool Update(Prestiti obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "Update  prestiti set data_ritorno = current_date  where ID=@id  ";
                cmd.Parameters.AddWithValue("@id", obj.Id);
               


                try
                {
                    conn.Open();

                    int affRows = cmd.ExecuteNonQuery();
                    if (affRows > 0)
                        risultato = true;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        internal bool GetById(Prestiti prer)
        {
            {
                //Prestiti pre1 = new Prestiti();
                bool risultato = false;
                using (SqlConnection conn = new SqlConnection(Config.credenziali))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                  
                    cmd.CommandText = "SELECT  Nome,Cognome,Titolo, Data_prestito , data_ritorno FROM Prestiti  join utenti on UtenteRif=UtenteID join Libri on LibroRif= LibroId   where Prestiti.ID=@id  ";

                    cmd.Parameters.AddWithValue("@id", prer.Id);
                    try
                    {
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            nominativo1 = reader.GetString(0);
                            nominativo2 = reader.GetString(1);
                            librotit = reader.GetString(2);
                            dataprest = reader.GetDateTime(3);
                            //DateTime? dataritor = reader.GetDateTime(4);

                            DateTime? datarestituzione = reader.IsDBNull(reader.GetOrdinal("data_ritorno"))
                                 ? (DateTime?)null
                                 : reader.GetDateTime(reader.GetOrdinal("data_ritorno"));
                            if (datarestituzione != null)
                            {
                                Console.WriteLine("prestito gia restituito ");
                                Console.WriteLine($"[prestiti]utente : {nominativo1}  {nominativo2}   libro :{librotit} data prestito :{dataprest}   ");
                            }
                            else
                                Console.WriteLine("trovato.");
                                 risultato = true;
                            
                           // Console.WriteLine(Prestiti.ToString());

                            //Console.WriteLine( $"[prestiti]utente : {nominativo1}  {nominativo2}   libro :{librotit} data prestito : {dataprest }  ")  ;
                            //Console.WriteLine($"ID: {id}, Data Prestito: {dataPrestito:dd/MM/yyyy}, Data Ritorno: {(dataRitorno.HasValue ? dataRitorno.Value.ToString("dd/MM/yyyy") : "N/A")}, UtenteRIF: {utenteRIF}, LibroRIF: {libroRIF}");
                        }
                        else
                        {
                            Console.WriteLine("Nessun record trovato con l'ID specificato ");
                        }

                      
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }

               return risultato;
            }
        }
    }
}

