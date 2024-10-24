using Esercizio_vacanza.Models;
using Esercizio_vacanza.Repository;

namespace Esercizio_vacanza.Services
{
    public class DestinazioneService : IService<DestinazioneDTO>
    {
        private readonly DestinazioneRepo _repository;

        public DestinazioneService(DestinazioneRepo repository)
        {
            _repository = repository;
        }

        public DestinazioneDTO? Cerca(string varCod)
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

        public IEnumerable<DestinazioneDTO> Lista()
        { 

            List<DestinazioneDTO> destinazioneDTOs = new List<DestinazioneDTO>();

            List<Destinazione> elenco = _repository.GetAll().ToList();
            foreach (Destinazione destina in elenco)
            {
                DestinazioneDTO destinazioneTEMP = new DestinazioneDTO()
                {
                    
                    nom = destina.nome,
                    des=destina.descrizione,
                    pae=destina.paese,
                    fot=destina.foto

                  
                };


                destinazioneDTOs.Add(destinazioneTEMP);
            }
            return destinazioneDTOs;

        }

        public IEnumerable<DestinazioneDTO> Listadespac(string varCodice)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<DestinazioneDTO> Listadespac(string varCodice)
        //{

        //        List<DestinazioneDTO> destinazioneDTOs = new List<DestinazioneDTO>();

        //        List<Destinazione> elenco = _repository.GetAll().ToList();
        //        foreach (Destinazione destina in elenco)
        //        {
        //        if (destina.destinazioneID == coddes) { 
        //        DestinazioneDTO destinazioneTEMP = new DestinazioneDTO()

        //            {

        //                nom = destina.nome,
        //                des = destina.descrizione,
        //                pae = destina.paese,
        //                fot = destina.foto


        //            };


        //            destinazioneDTOs.Add(destinazioneTEMP);
        //        }

        //        return destinazioneDTOs;



        //    }
        //}

        public bool Update()
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Destinazione> GetAllbypacchetto(int id)
        //{


        //    List<DestinazioneDTO> destinazioneDTOs = new List<DestinazioneDTO>();

        //    List<Destinazione> elenco = _repository.GetAll().ToList();
        //    foreach (Destinazione desti in elenco)
        //    {  
        //        DestinazioneDTO destinazioneTEMp = new DestinazioneDTO()
        //        {
        //            nom = desti.nome,
        //            des = desti.descrizione,
        //            pae = desti.paese,
        //            fot = desti.foto


        //        };
        //        if(desti.pacchettoRIF)

        //        destinazioneDTOs.Add(destinazioneTEMp);
        //    }
        //    return destinazioneDTOs;



   // }
       
    }
}
