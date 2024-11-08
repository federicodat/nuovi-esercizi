using A_CHAT.Models;
using A_CHAT.Repos;

namespace A_CHAT.Services
{
    public class UtenteService : IServiceLettura<Utente>, IServiceScrittura<Utente>
          
    {
        private readonly UtenteRepo _repo;

        public UtenteService(UtenteRepo repo)
        {
            _repo = repo;
        }
    
public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool EliminaUtente(string varUser)
        {
            return _repo.EliminaUtente(varUser);
        }

      

        public Utente? Details(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Utente u)
        {

            Utente iscr = new Utente()
            {

                username = u.username,
                passw = u.passw,
                email = u.email

            };



            return _repo.Create(iscr);
        }
    

        public IEnumerable<Utente> List()
        {
            return _repo.GetAll();
        }

        public Utente? CercaPerID(int id)
        {
            return _repo.GetByID(id);
        }
        public Utente? CercaPerCodice(string varCod)
        {
            return _repo.GetByCodice(varCod);
        }

        public bool ModificaUtente(Utente ute)
        {
            return _repo.Update(ute);
        }

        public bool Update(Utente t)
        {
            throw new NotImplementedException();
        }

        //iscrizione utente
        //public bool Insert(UtenteDTO u)
        //{

        //    Utente iscr = new Utente()
        //    {

        //        username = u.usern,
        //        passw =u.pas,
        //        email=u.emai

        //    };



        //    return _repo.Create(iscr);
        //}


       public UtenteDTO ? cerca (string varU, string varP)
         
        {
            UtenteDTO? risultato = null;

            Utente? uto = _repo.GetByUsernamePasswordU(varU,varP);
           
            if (uto is not null)
            {
                risultato = new UtenteDTO()
                {
                    usern = uto.username,
                    pas = uto.passw,
                    emai = uto.email,
                };
            }

            return risultato;
        }

        internal static object GetInstance()
        {
            throw new NotImplementedException();
        }

       


        public UtenteDTO? CercaUPerId(int id)
        {
            UtenteDTO? risultato = null;
            Utente? uto = _repo.GetByID(id);


            if (uto is not null)
            {
                risultato = new UtenteDTO()
                {
                    usern = uto.username,
                    emai= uto.email
                    
                };
            }

            return risultato;
        }
        //----------------------
    }
}
