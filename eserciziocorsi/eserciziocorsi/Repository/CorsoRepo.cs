using eserciziocorsi.Models;

namespace eserciziocorsi.Repository
{
    public class CorsoRepo : IRepo<Corso>
    {
        private readonly corsoContext _context;

        public CorsoRepo(corsoContext context)
        {
            _context = context;
        }
        public bool Create(Corso entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Corso? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Corso> GetAll()
        {
            return _context.Corsi.ToList();
        }

        public bool Update(Corso entity)
        {
            throw new NotImplementedException();
        }
    }
}
