using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_gestione_libreria.Models.DAL
{
    internal class LibriDAO  
    {
        private static LibriDAO? instance;
        public static string libtit = "";
        public static bool libdis =false;
        public static decimal libann= 0; 
        public static int libid= 0; 
        public static LibriDAO GetInstance()
        {
            if (instance is null)
                instance = new LibriDAO();

            return instance;
        }
        private LibriDAO()
        {

        }
        public bool Delete(Libri obj)
        {
            bool risultato = false;
            

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "Delete from Libri where ID=@id  ";
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

        public List<Libri> GetAll()
        {
            {
                List<Libri> risultato = new List<Libri>();

                using (SqlConnection conn = new SqlConnection(Config.credenziali))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT  Titolo, Anno, Disponibilita  FROM Libri";

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Libri libro = new Libri()
                            {
                                Titolo = reader.GetString(0),
                                Anno = reader.GetDecimal(1),
                               Disponibilita = reader.GetBoolean(2)
                                 
                            };

                            risultato.Add(libro);
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

                return risultato;
            }
        }

       
        public bool Insert(Libri obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Libri (titolo, anno) VALUES (@tit, @ann)";
                cmd.Parameters.AddWithValue("@tit", obj.Titolo);
                cmd.Parameters.AddWithValue("@ann", obj.Anno);
       

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
        public bool Updatedisp(Libri obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "Update  Libri set disponibilita =@disp  where ID=@id  ";
                cmd.Parameters.AddWithValue("@id", obj.Id);
                cmd.Parameters.AddWithValue("@disp", obj.Disponibilita);
     


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
        public bool Update(Libri obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "Update  Libri set Titolo =@tit, Anno =@ann where ID=@id  ";
                cmd.Parameters.AddWithValue("@id", obj.Id);
                cmd.Parameters.AddWithValue("@tit", obj.Titolo);
                cmd.Parameters.AddWithValue("@ann", obj.Anno);
               

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
        public bool GetById(string inIDpde)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
     

                 SqlCommand cmd = new SqlCommand();
                     cmd.Connection = conn;
                    cmd.CommandText = "SELECT  Titolo, Anno, Disponibilita ,libroID FROM Libri where Id= @id";

                cmd.Parameters.AddWithValue("@id", inIDpde);
                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        libtit = reader.GetString(0);
                        libann = reader.GetDecimal(1);
                        libdis = reader.GetBoolean(2);
                        libid = reader.GetInt32(3);
           

                        if (libdis is false )
                        {
                            Console.WriteLine("Libro non disponibile ");
                            
                                
                        }
                        //else
                        //    //Console.WriteLine("trovato.");
                        Console.WriteLine($"[Libro] titolo: {libtit} anno :  {libann} ");
 

                        risultato = true;

                       
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

        internal void Updatedisp(object obj)
        {
            throw new NotImplementedException();
        }
    }

         
    }


