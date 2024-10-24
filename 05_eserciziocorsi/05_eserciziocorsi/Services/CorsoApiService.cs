using _05_eserciziocorsi.Models;
using _05_eserciziocorsi.Repos;

namespace _05_eserciziocorsi.Services
{
    public class CorsoApiService : IServiceLettura<CorsoDTO>
    {
        private readonly CorsoRepo _repo;

        public CorsoApiService(CorsoRepo repo)
        {
            _repo = repo;
        }

        public CorsoDTO? Details(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CorsoDTO> List()
        {
            IEnumerable<Corso> lista = _repo.GetAll();

            List<CorsoDTO> risultato = new List<CorsoDTO>();

            foreach (Corso c in lista)
            {
                risultato.Add(new CorsoDTO()
                {
                    Cod = c.CodCorso,
                    Dat = c.DataCorso,
                    Des = c.Descrizione,
                    Nom = c.Nome,
                    Par = c.MaxPartecipanti,
                    Pre = c.Prezzo
                });
            }

            return risultato;
        }
    }
}