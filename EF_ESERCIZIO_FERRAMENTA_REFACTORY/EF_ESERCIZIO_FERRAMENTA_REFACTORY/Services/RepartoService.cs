using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models;
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Services
{
    public class RepartoService : IService<RepartoDTO>
    {
        private readonly RepartoRepo _repository;
        public RepartoService(RepartoRepo repository)
        {
            _repository = repository;
        }

        public RepartoDTO? Cerca(string cod)
        {
            RepartoDTO? risultato = null;

            Reparto? ferramenta = _repository.GetByCodice(cod);
            if (ferramenta is not null)
            {
                risultato = new RepartoDTO()
                {
                    Cod = ferramenta.repartoCOD,
                    Fil = ferramenta.fila,
                    Nom = ferramenta.nome
                };
            }

            return risultato;
        }


        public bool   Delete (string cod)
        {
              bool risultato =false;

            Reparto? repo = _repository.GetByCodice(cod);
            if (repo is not null)
            {
                _repository.Eliminarep(cod);
                risultato = true;
            }
                


               return risultato;           
            

        }
        public IEnumerable<RepartoDTO> Lista()
        {
         
            List<RepartoDTO> repartoDTOs = new List<RepartoDTO>();

            List<Reparto> elenco = _repository.GetAll().ToList();
            foreach (Reparto reparto in elenco)
            {
                RepartoDTO repartoTemp = new RepartoDTO()
                {
                    Cod = reparto.repartoCOD,
                    Nom = reparto.nome,
                    Fil = reparto.fila
                };

                repartoDTOs.Add(repartoTemp);
            }
            return repartoDTOs;



        }
        public bool Inserisci(RepartoDTO repDto)
        {
             
            Reparto repa = new Reparto()
            {
                repartoCOD = repDto.Cod is not null ? repDto.Cod : Guid.NewGuid().ToString().ToUpper(),
                fila = repDto.Fil,
                nome = repDto.Nom
            };


            return _repository.Create(repa);
               
        }
        internal object GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Inserisci()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Update(RepartoDTO objrep)
        {

            bool risultato = false;

            Reparto? repo = _repository.GetByCodice(objrep.Cod);
            if (repo is not null)
            {
                Reparto temp = repo;


                //Reparto.repartoID = temp.repartoID;

                objrep.Cod = objrep.Cod is not null ? objrep.Cod : temp.repartoCOD;
                objrep.Fil = objrep.Fil is not null ?  objrep.Fil : temp.fila ;
                objrep.Nom = objrep.Nom is not null ?  objrep.Nom : temp.nome  ;

               

                repo.repartoID = temp.repartoID;
                repo.fila = objrep.Fil;
                repo.repartoCOD = objrep.Cod;
                repo.nome = objrep.Nom;

                return _repository.Update(repo);


            }



            return risultato;
            


            

        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
         
    }
 
