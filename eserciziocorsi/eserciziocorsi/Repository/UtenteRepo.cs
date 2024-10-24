using eserciziocorsi.Models;
using Microsoft.EntityFrameworkCore;

namespace eserciziocorsi.Repository
{
    public class UtenteRepo : IRepo<Utente>
    {
        private readonly corsoContext _context;

        public UtenteRepo(corsoContext context)
        {
            _context = context;
        }


        public static UtenteRepo? instance;

        public static UtenteRepo GetInstance()
        {
            if (instance == null)
                instance = new UtenteRepo();

            return instance;
        }
        public UtenteRepo() { }
        public bool Create(Utente entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Utente? Get(int id)
        {
            throw new NotImplementedException();
        }

      

        public IEnumerable<Utente> GetAll()
        {
            return _context.Utenti.ToList();
        }

        public bool Update(Utente entity)
        {
            throw new NotImplementedException();
        }
    
        public Utente GetByCodice(string varute)
        {
           
            return _context.Utenti.SingleOrDefault(u => u.userid == varute);


             


        }

         
    }
}
