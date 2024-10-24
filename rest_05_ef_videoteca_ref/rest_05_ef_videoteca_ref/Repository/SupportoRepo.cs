using rest_05_ef_videoteca_ref.Models;

namespace rest_05_ef_videoteca_ref.Repository
{
    public class SupportoRepo : IRepo<Supporto>
    {
        private readonly BlockbusterContex _context;

        public SupportoRepo(BlockbusterContex context)
        {
            _context = context;
        }
        public bool Create(Supporto entity)
        {
            bool risultato = false;
            try
            {
                _context.Supporti.Add(entity);
                _context.SaveChanges();

                risultato = true;


            }
            catch (Exception ex) { Console.WriteLine(ex.Message);
               
            }
            return risultato ;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Supporto? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supporto> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Supporto entity)
        {
            throw new NotImplementedException();
        }
    }
}
