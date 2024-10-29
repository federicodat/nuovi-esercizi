using MongoDB.Bson.Serialization.Serializers;
using Rest_08_Mongodb.Models;
using Rest_08_Mongodb.Repos;

namespace Rest_08_Mongodb.Services
{
    public class ImpiegatoService
    {
        private readonly ImpiegatoRepo _repo;
        public ImpiegatoService(ImpiegatoRepo repo)
        { _repo = repo; }


        public bool Inserisci(ImpiegatoDTO impDTO)
        {
            Impiegato imp = new Impiegato()
            {
                Nominativo = impDTO.Nom,
                Matricola = impDTO.Mat,
                Dipartimento = impDTO.Dip,
                DataAssu = impDTO.Dat


            };
            return _repo.Create(imp);
        }
            public IEnumerable<ImpiegatoDTO> CercaTutti()
            {
                List<ImpiegatoDTO> risultato = new List<ImpiegatoDTO>();

                foreach (Impiegato imp in _repo.GetAll())
                {
                    risultato.Add(new ImpiegatoDTO()
                    {
                        Dat = (DateTime)imp.DataAssu,
                        Dip = imp.Dipartimento,
                        Mat = imp.Matricola,
                        Nom = imp.Nominativo
                    });
                }

                return risultato;
            }

            public ImpiegatoDTO? CercaPerMatricola(string matricola)
            {
                ImpiegatoDTO? risultato = null;
                Impiegato? imp = _repo.GetByMatricola(matricola);

                if (imp is not null)
                {
                    risultato = new ImpiegatoDTO()
                    {
                        Dat = (DateTime)imp.DataAssu,
                        Dip = imp.Dipartimento,
                        Mat = imp.Matricola,
                        Nom = imp.Nominativo
                    };
                }

                return risultato;
            }

        public bool elimina(string varMat)
        {
         
           
            return _repo.Elimina(varMat);
        }
    }
    }