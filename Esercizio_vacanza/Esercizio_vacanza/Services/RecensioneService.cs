using Esercizio_vacanza.Models;
using Esercizio_vacanza.Repository;

namespace Esercizio_vacanza.Services
{

    public class RecensioneService : IService<RecensioneDTO>
    {
        private readonly RecensioneRepo _repository;

        public RecensioneService(RecensioneRepo repository)
        {
            _repository = repository;
        }

        public RecensioneDTO? Cerca(string varCod)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        
        public bool InserisciRecensione(RecensioneDTO recDto)
        {

            Recensione rece = new Recensione()
            {
                Utente = recDto.Ute,
                commento = recDto.comm,
                Voto = recDto.Vot,
                datarece= DateTime.Now,
                PacchettoRif= 1 //recDto.rifpac
            };


            return _repository.Create(rece);

        }

        public bool Inserisci()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecensioneDTO> Lista(int idpac)
        {
            List<RecensioneDTO> recensioneDTOs = new List<RecensioneDTO>();

            List<Recensione> elenco = _repository.GetAll().ToList();
            foreach (Recensione rece in elenco)
            {
                if (rece.PacchettoRif == idpac) {
                    RecensioneDTO recensioneTemp = new RecensioneDTO()
                    {

                        Ute = rece.Utente,
                        Vot = rece.Voto,
                        comm = rece.commento,
                        datar = rece.datarece




                    };




                    recensioneDTOs.Add(recensioneTemp);

                }
                
            }
            return recensioneDTOs;



        }
    

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecensioneDTO> Lista()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecensioneDTO> Listadespac(string varCodice)
        {
            throw new NotImplementedException();
        }
    }
}

