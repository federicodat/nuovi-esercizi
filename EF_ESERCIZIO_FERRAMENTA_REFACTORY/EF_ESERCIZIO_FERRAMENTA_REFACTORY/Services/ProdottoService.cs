using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models;
using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Repository;

namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Services
{
    public class ProdottoService : IService<ProdottoDTO>
    {
        private readonly ProdottoRepo _repository;

        public ProdottoService(ProdottoRepo repository)
        {
            _repository = repository;
        }

        public ProdottoDTO? Cerca(string varCod)
        {
            ProdottoDTO? risultato = null;

            Prodotto? ferramenta = _repository.GetByCodice(varCod);
            if (ferramenta is not null)
            {
                risultato = new ProdottoDTO()
                { 
                    Codi = ferramenta.CodiceBarre,
                    Nom = ferramenta.Nome,
                    Des = ferramenta.Descrizione,
                    Prez = ferramenta.Prezzo,
                    Qua = ferramenta.Quantita
 
                };
            }

            return risultato;
        }

        public bool Delete(string codi)
        {
            bool risultato = false;

            Prodotto? repo = _repository.GetByCodice(codi);
            if (repo is not null)
            {
                _repository.Eliminarep(codi);
                risultato = true;
            }



            return risultato;


        }
        public IEnumerable<ProdottoDTO> Lista()
        {

            List<ProdottoDTO> prodottoDTOs = new List<ProdottoDTO>();

            List<Prodotto> elenco = _repository.GetAll().ToList();
            foreach (Prodotto prodotto in elenco)
            {
                ProdottoDTO prodottoTemp = new ProdottoDTO()
                {
                    Codi = prodotto.CodiceBarre,
                    Nom = prodotto.Nome,
                    Des = prodotto.Descrizione, 
                    Prez = prodotto.Prezzo,
                    Qua = prodotto.Quantita

                };


                prodottoDTOs.Add(prodottoTemp);
            }
            return prodottoDTOs;



        }
        public bool Inserisci(ProdottoDTO proDto )
        {

            Prodotto prodo = new Prodotto()
            {
                CodiceBarre = proDto.Codi is not null ? proDto.Codi : Guid.NewGuid().ToString().ToUpper(),
                Prezzo = proDto.Prez,
                Descrizione = proDto.Des,
                Quantita = proDto.Qua,
                Nome = proDto.Nom,
                RepartoRif = proDto.rifrep
            };


            return _repository.Create(prodo);

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

        public bool Update(ProdottoDTO objpro)
        {

            bool risultato = false;

            Prodotto? prodo = _repository.GetByCodice(objpro.Codi);
            if (prodo is not null)
            {
                Prodotto temp = prodo;


                //Reparto.repartoID = temp.repartoID;

                objpro.Codi = objpro.Codi is not null ? objpro.Codi : temp.CodiceBarre;
                objpro.Des = objpro.Des is not null ? objpro.Des : temp.Descrizione;
                objpro.Prez = objpro.Prez is not null ? objpro.Prez : temp.Prezzo;
                //objpro.Qua = objpro.Qua =  0  objpro.Qua : temp.Quantita;
                objpro.Nom = objpro.Nom is not null ? objpro.Nom : temp.Nome;



                prodo.ProdottoID = temp.ProdottoID;
                prodo.Descrizione = objpro.Des;
                prodo.Prezzo = objpro.Prez;
                prodo.CodiceBarre = objpro.Codi;
                prodo.Quantita = objpro.Qua;
                prodo.Nome = objpro.Nom;

                return _repository.Update(prodo);


            }



            return risultato;





        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }

}

