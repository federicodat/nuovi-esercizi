using eserciziocorsi.Models;

namespace eserciziocorsi.Repository
{
    public class IscrizioneRepo : IRepo<Iscrizione>
    {
        private readonly corsoContext _context;

        public IscrizioneRepo(corsoContext context)
        {
            _context = context;
        }
        public bool Create(Iscrizione entity)
        {
          
      
  
            try
            {
                _context.Iscrizioni.Add(entity);

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

        public Iscrizione? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Iscrizione> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Iscrizione entity)
        {
            throw new NotImplementedException();
        }
    }
}
