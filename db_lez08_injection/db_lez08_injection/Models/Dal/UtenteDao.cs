using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez08_injection.Models.Dal
{
    internal class UtenteDao : IDaoLettura<Utente>
    {
     

        public Utente Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Utente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utente GetByUsername(string varuser)    
        {
            Utente? risultato = null;

            using (SqlConnection conn = new Sqlconnection(Config.credenziali))
            {

                string query = $"SELECT utenteId,usern,passw,ruolo From Utente where usern ='{varuser}' and passw='{varPass}' ";

                SqlCommand cmd = new SqlCommand();

                return risultato;

            }
    }
}
