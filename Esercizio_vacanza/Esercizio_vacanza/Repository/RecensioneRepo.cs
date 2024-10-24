using Esercizio_vacanza.Models;
using Microsoft.EntityFrameworkCore;

namespace Esercizio_vacanza.Repository
{
    public class RecensioneRepo : IRepo<Recensione>
    {
        private readonly VacanzeContext _context;

        public RecensioneRepo(VacanzeContext context)
        {
            _context = context;
        }
        public bool Create(Recensione entity)
        {
            try
            {
                _context.Recensioni.Add(entity);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Recensione? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recensione> GetAll()
        {
            _context.Recensioni.ToList();
            return _context.Recensioni;
        }

        public bool Update(Recensione entity)
        {
            throw new NotImplementedException();
        }
    }
}
