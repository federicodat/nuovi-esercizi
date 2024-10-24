using rest04_ef_videoteca.Controllers;
using rest04_ef_videoteca.Models;
using rest04_ef_videoteca.Repository;

namespace rest04_ef_videoteca.Services
{


    public class VideotecaService
    {
        private static VideotecaService? instance;

        public static VideotecaService GetInstance()
        {
            if (instance == null)
                instance = new VideotecaService();

            return instance;
        }
        private VideotecaService() { }


        public VideotecaDTO? CercaVideoteca(string codice)
        {
            VideotecaDTO? risultato = null;

            Videoteca? vidt = VideotecaRepo.GetInstance().GetByCodiceBarre(codice);
            if (vidt is not null)
            {
                risultato = new VideotecaDTO()
                {
                    Cod = vidt.Codice,
                    Ind = vidt.Indirizzo,
                    Nom = vidt.Nome
                };
            }

            return risultato;
        }
            public List<VideotecaDTO> CercaTutteVideoteche()
            {
                List<VideotecaDTO> videotecaDTOs = new List<VideotecaDTO>();

                List<Videoteca> elenco = VideotecaRepo.GetInstance().GetAll();
                foreach (Videoteca v in elenco)
                {
                    VideotecaDTO temp = new VideotecaDTO()
                    {
                        Cod = v.Codice,
                        Ind = v.Indirizzo,
                        Nom = v.Nome
                    };

                    videotecaDTOs.Add(temp);
                }

                return videotecaDTOs;
            }
    }



}
