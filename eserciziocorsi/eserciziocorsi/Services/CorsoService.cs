using eserciziocorsi.Models;
using eserciziocorsi.Repository;

namespace eserciziocorsi.Services
{
    public class CorsoService : IService<CorsoDTO>
    {
        private readonly CorsoRepo _repository;

        public CorsoService(CorsoRepo repository)
        {
            _repository = repository;
        }
        public CorsoDTO? Cerca(string varCod)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Inserisci()
        {
            throw new NotImplementedException();
        }

      

        public IEnumerable<CorsoDTO> Lista()
        {
            List<CorsoDTO> corsoDTOs = new List<CorsoDTO>();

            List<Corso> elenco = _repository.GetAll().ToList();
            foreach (Corso corso in elenco)
            {
                CorsoDTO corsoTemp = new CorsoDTO()
                {
                    cod = corso.codice,
                    nom=corso.nome,
                    des=corso.descrizione,
                    pre=corso.prezzo,
                    max=corso.maxpart
 

                };


                corsoDTOs.Add(corsoTemp);
            }
            return corsoDTOs;

        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
