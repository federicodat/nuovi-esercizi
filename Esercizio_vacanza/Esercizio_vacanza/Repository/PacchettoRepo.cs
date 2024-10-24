using Esercizio_vacanza.Models;

namespace Esercizio_vacanza.Repository
{
    public class PacchettoRepo : IRepo<Pacchetto>
    {
        private readonly VacanzeContext _context;

        public PacchettoRepo(VacanzeContext context)
        {
            _context = context;
        }
        public bool Create(Pacchetto entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pacchetto? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pacchetto> GetAll()
        {
            _context.Pacchetti.ToList();
            return _context.Pacchetti;
        }

        public bool Update(Pacchetto entity)
        {
            throw new NotImplementedException();
        }

        public Pacchetto? CercaPerCodice(string varcod)
        {
          
                 return _context.Pacchetti.FirstOrDefault(r => r.nome == varcod);
        }
    }
}
