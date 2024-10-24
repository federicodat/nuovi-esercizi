using Esercizio_vacanza.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewComponents;
namespace Esercizio_vacanza.Repository
{
    public class DestinazioneRepo : IRepo<Destinazione>
    {
        private readonly VacanzeContext _context;

        public DestinazioneRepo(VacanzeContext context)
        {
            _context = context;
        }

        public bool Create(Destinazione entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Destinazione? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Destinazione> GetAll()
        {
            return _context.Desinazioni.ToList();
        }

      


        public bool Update(Destinazione entity)
        {
            throw new NotImplementedException();
        }
    }
}
