using _05_eserciziocorsi.Models;
using _05_eserciziocorsi.Repos;

namespace _05_eserciziocorsi.Services
{
    public class AdminService
    {
        private readonly AdminRepo _repo;

        public AdminService(AdminRepo repo)
        {
            _repo = repo;
        }

        public bool VerificaUsernamePassword(AdminDTO adDto)
        {
            bool risultato = false;

            if (adDto.User is not null && adDto.Pass is not null)
            {
                Admin? adm = _repo.GetByUsernamePassword(adDto.User, adDto.Pass);
                if (adm is not null)
                    risultato = true;
            }

            return risultato;
        }
    }
}