using eserciziocorsi.Models;

namespace eserciziocorsi.Repository
{
    public class CorsistaRepo : IRepo<Corsista>
    {
        private readonly corsoContext _context;

        public CorsistaRepo(corsoContext context)
        {
            _context = context;
        }
        public bool Create(Corsista entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Corsista? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Corsista> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Corsista entity)
        {
            throw new NotImplementedException();
        }
    }

}