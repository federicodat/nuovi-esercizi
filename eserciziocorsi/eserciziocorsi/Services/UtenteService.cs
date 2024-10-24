using eserciziocorsi.Models;
using eserciziocorsi.Repository;

namespace eserciziocorsi.Services
{
    public class UtenteService : IService<UtenteDTO>
    {
        
            private static UtenteService? instance;

            public static UtenteService GetInstance()
            {
                if (instance == null)
                    instance = new UtenteService();

                return instance;
            }
        private UtenteService() { }
        private readonly UtenteRepo _repository;

        public UtenteService(UtenteRepo repository)
        {
            _repository = repository;
        }
        public Utente? Cerca(string varCod)
        {
            throw new NotImplementedException();
        }

        public UtenteDTO? Cercaute(string varute)
        {
            UtenteDTO? risultato = null;

      
                Utente? utl = UtenteRepo.GetInstance().GetByCodice(varute);

            if (utl is not null)
            {
                risultato = new UtenteDTO()
                {
                    us = utl.userid,
                    pw = utl.passw,
                    ru = utl.ruolo

                };
            }



            return risultato;
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Inserisci()
        {
            throw new NotImplementedException();
        }

  

        public bool Update()
        {
            throw new NotImplementedException();
        }

        UtenteDTO? IService<UtenteDTO>.Cerca(string varCod)
        {
            throw new NotImplementedException();
        }

      

        public IEnumerable<UtenteDTO> Lista()
        {
            List<UtenteDTO> utenteDTOs = new List<UtenteDTO>();

            List<Utente> elenco = _repository.GetAll().ToList();
            foreach (Utente utt in elenco)
            {
                UtenteDTO uTemp = new UtenteDTO()
                {
                    us = utt.userid,
                    pw = utt.passw,
                    ru = utt.ruolo
                  

                };


                utenteDTOs.Add(uTemp);
            }
            return utenteDTOs;

        }
    }
}
