using A_CHAT.Models;
using A_CHAT.Repos;

namespace A_CHAT.Services
{
    public class AmministratoreService :IServiceLettura<Amministratore>
   
    {
        private readonly AmministratoreRepo _repo;

        public AmministratoreService(AmministratoreRepo repo)
        {
            _repo = repo;
        }

        public Amministratore? Details(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Amministratore> List()
        {
            throw new NotImplementedException();
        }

        public bool VerificaUsernamePassword(AmministratoreDTO adDto)
        {
            bool risultato = false;

            if (adDto.User is not null && adDto.Pass is not null)
            {
                Amministratore? adm = _repo.GetByUsernamePassword(adDto.User, adDto.Pass);
                if (adm is not null)
                    risultato = true;
            }

            return risultato;
        }
    }
}