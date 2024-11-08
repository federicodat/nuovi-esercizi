using A_CHAT.Context;
using A_CHAT.Models;

namespace A_CHAT.Repos
{
    public class AmministratoreRepo :IRepoLettura<Amministratore>
    {
         
            private readonly ChatContext _context;

            public AmministratoreRepo(ChatContext context)
            {
                _context = context;
            }

        public Amministratore? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Amministratore> GetAll()
        {
            throw new NotImplementedException();
        }

        public Amministratore? GetByUsernamePassword(string user, string pass)
            {
                return _context.Amministratori.FirstOrDefault(a => a.User == user && a.Pass == pass);
            }
        }
    }