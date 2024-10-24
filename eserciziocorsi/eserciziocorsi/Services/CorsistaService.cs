using eserciziocorsi.Models;
using eserciziocorsi.Repository;

namespace eserciziocorsi.Services
{
    public class CorsistaService :IService<CorsistaDTO>
    {
        private readonly CorsistaRepo _repository;

        public CorsistaService(CorsistaRepo repository)
        {
            _repository = repository;
        }

        public CorsistaDTO? Cerca(string varCod)
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

        public IEnumerable<CorsistaDTO> Lista()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
