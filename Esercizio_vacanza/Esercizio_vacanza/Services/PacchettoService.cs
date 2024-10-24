using Esercizio_vacanza.Models;
using Esercizio_vacanza.Repository;
namespace Esercizio_vacanza.Services
{
    public class PacchettoService : IService<PacchettoDTO>
    {
        private readonly PacchettoRepo _repository;

        public PacchettoService(PacchettoRepo repository)
        {
            _repository = repository;
        }
        public PacchettoDTO? Cerca(string varCod)
        {
            PacchettoDTO? risultato = null;

            Pacchetto? pacchetto = _repository.CercaPerCodice(varCod);
            if (pacchetto is not null)
            {
                risultato = new PacchettoDTO()
                {
                    nom = pacchetto.nome,
                     dura= pacchetto.durata,
                     prez = pacchetto.prezzo,
                     dataf=pacchetto.datafin,
                     datai = pacchetto.dataini
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
        public IEnumerable<PacchettoDTO> Lista()
        {

            List<PacchettoDTO> pacchettoDTOs = new List<PacchettoDTO>();

            List<Pacchetto> elenco = _repository.GetAll().ToList();
            foreach (Pacchetto pacco in elenco)
            {
                PacchettoDTO pacchettoTEMP = new PacchettoDTO()
                {

                    nom = pacco.nome,
                    prez = pacco.prezzo ,
                    dura= pacco.durata,
                    datai = pacco.dataini,
                    dataf = pacco.datafin


                };
 
 
     

    pacchettoDTOs.Add(pacchettoTEMP);
            }
            return pacchettoDTOs;



        }

        public IEnumerable<PacchettoDTO> Listadespac(string varCodice)
        {
            throw new NotImplementedException();
        }
    }
}
