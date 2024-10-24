using _05_eserciziocorsi.Contex;
using _05_eserciziocorsi.Models;

namespace _05_eserciziocorsi.Repos
{
    public class AdminRepo
    {
        private readonly PoloFormativoContext _context;

        public AdminRepo(PoloFormativoContext context)
        {
            _context = context;
        }

        public Admin? GetByUsernamePassword(string user, string pass)
        {
            return _context.Amministratori.FirstOrDefault(a => a.User == user && a.Pass == pass);
        }
    }
}