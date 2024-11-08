using A_CHAT.Context;
using A_CHAT.Models;

namespace A_CHAT.Repos
{
    public class UtenteRepo : IRepoLettura<Utente> ,IRepoScrittura<Utente>
    {
        private readonly ChatContext _context;
        private readonly ILogger<UtenteRepo> _logger;

        public UtenteRepo(ChatContext context, ILogger<UtenteRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        internal static object GetInstance()
        {
            throw new NotImplementedException();
        }

        

        

        public bool EliminaUtente(string varUser)
        {
            var utente = _context.Utenti.FirstOrDefault (l => l.username == varUser);
            if (utente != null)
            {
                _context.Utenti.Remove(utente);
                _context.SaveChanges();
                return true;
            }
            return false;
        }//

        public Utente? GetUt(string varUser)
        {
            var utente = _context.Utenti.FirstOrDefault();
            if (utente != null)
                return utente;
            return null;
            
        }


        public Utente? GetByCodice(string cod)
        {
            return _context.Utenti.FirstOrDefault(c => c.username == cod);
        }

        public Utente? GetByUser(string varUser)
        {
            Utente? risultato = null;
            _context.Utenti.FirstOrDefault(u => u.username == varUser);

          

            return risultato;
        }
        public IEnumerable<Utente> GetAll()
        {
            return _context.Utenti.ToList();
        }

        public bool Create(Utente u)
        {
            bool risultato = false;

            try
            {
                _context.Utenti.Add(u);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return risultato;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

      

        public Utente? GetByID(int id)
        {
            Utente? risultato = _context.Utenti.FirstOrDefault(u => u.utenteID == id);
            return risultato;
        }

        public bool Update(Utente entity)
        {
            bool risultato = false;

            try
            {
                _context.Utenti.Update(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }
        //login

        public Utente? GetByUsernamePasswordU(string user, string pass)
        {
            return _context.Utenti.FirstOrDefault(a => a.username == user && a.passw == pass);
        }

        public Utente? Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
