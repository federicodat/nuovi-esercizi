using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_gestione_libreria.Models.DAL
{
    internal class UtenteDao : IDaoLettura<Utenti>, IDaoscrittura<Utenti>
    {
        private static UtenteDao? instance;
        private string nome;
        private string cognome;
        public static int uteid;

        public static UtenteDao GetInstance()
        {
            if (instance is null)
                instance = new UtenteDao();

            return instance;
        }
        private UtenteDao()
        {

        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Utenti> GetAll()
        {
            {
                List<Utenti> risultato = new List<Utenti>();

                using (SqlConnection conn = new SqlConnection(Config.credenziali))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT  Nome, Cognome, email  FROM Utenti";

                    try
                    {
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Utenti ute = new Utenti()
                            {
                                Nome = reader.GetString(0),
                                Cognome = reader.GetString(1),
                                Email = reader.GetString(2) 

                            };

                            risultato.Add(ute);
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

        public bool Insert(Utenti obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Utenti (Nome, Cognome, email)  VALUES (@nom, @cog,@mail)";
                cmd.Parameters.AddWithValue("@nom", obj.Nome);
                cmd.Parameters.AddWithValue("@cog", obj.Cognome);
                cmd.Parameters.AddWithValue("@mail", obj.Email);

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

        //public Utenti? GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

     
        public bool Update(Utenti obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "Update  Utenti set Nome =@nom, Cognome =@cog, email=@mail where ID=@id  ";
                cmd.Parameters.AddWithValue("@id", obj.Id);
                cmd.Parameters.AddWithValue("@nom", obj.Nome);
                cmd.Parameters.AddWithValue("@cog", obj.Cognome);
                cmd.Parameters.AddWithValue("@mail", obj.Email);

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
        public bool Delete(Utenti obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "Delete from Utenti where ID=@id  ";
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

        internal bool GetById(string inIDute)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT  Nome, Cognome ,UtenteID  FROM Utenti where Id= @id";

                cmd.Parameters.AddWithValue("@id", inIDute);
                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        nome= reader.GetString(0);
                        cognome= reader.GetString(1);
                        uteid= reader.GetInt32(2);


                        Console.WriteLine($"[Utente] nome: {nome} cognome :  {cognome} ");

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

        public Utenti? GetById(int id)
        {
            throw new NotImplementedException();
        }
        //---------------------------------------------------------
    }
    
}
