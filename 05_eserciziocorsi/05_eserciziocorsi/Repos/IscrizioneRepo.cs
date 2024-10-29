using _05_eserciziocorsi.Contex;
using _05_eserciziocorsi.Models;

namespace _05_eserciziocorsi.Repos
{
    public class IscrizioneRepo : IRepo<Iscrizione>
    {
        private readonly PoloFormativoContext _context;
        private readonly ILogger<IscrizioneRepo> _logger;

        public IscrizioneRepo(PoloFormativoContext context, ILogger<IscrizioneRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IscrizioneRepo()
        {
        }

        private static IscrizioneRepo? instance;

        public static IscrizioneRepo GetInstance()
        {
            if (instance == null)
                instance = new IscrizioneRepo();

            return instance;
        }

        public Iscrizione? GetByCodice(string cod)
        {
            return _context.Iscrizioni.FirstOrDefault(p => p.CodiceDis == cod);
        }
        public bool Create(Iscrizione t)
        {
            bool risultato = false;
          
            try
            {
                _context.Iscrizioni.Add(t); 
                _context.SaveChanges();

                risultato =true;
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

        public Iscrizione? Get(int id)
        {
            throw new NotImplementedException();
        }
        public Iscrizione? CercaPerCodice(string cod)
        {
            return _context.Iscrizioni.FirstOrDefault(i => i.Codice == cod);
        }
            
        public IEnumerable<Iscrizione> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Iscrizione t)
        {
            throw new NotImplementedException();
        }

        public bool Eliminareisc(string cod)
        {

            bool risultato = false;

            Iscrizione? iscri = GetByCodice(cod);

            if (iscri is not null)

                try
                {
                    _context.Iscrizioni.Remove(iscri);

                    _context.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return false;
                }


            return risultato;

        }

    }
}
