using Microsoft.AspNetCore.Http.HttpResults;
using MongoDB.Driver;
using Rest_08_Mongodb.Models;
using System;

namespace Rest_08_Mongodb.Repos
{
    public class ImpiegatoRepo : IRepoLettura<Impiegato>, IRepoScrittura<Impiegato>
    {
        private readonly   ILogger<ImpiegatoRepo> _logger;
        private IMongoCollection<Impiegato> impiegati;

        public ImpiegatoRepo(ILogger<ImpiegatoRepo> logger, IConfiguration configuration)
        {
            _logger = logger;
            string? connessione = configuration.GetValue<string>("MongoDBConnessione:DbLocale");
            string? database = configuration.GetValue<string>("MongoDBConnessione:NomeDatabase");

            MongoClient conn =new MongoClient(connessione);
            IMongoDatabase db = conn.GetDatabase(database);

            this.impiegati = db.GetCollection<Impiegato>("Impiegatos");

        }


        public bool Create(Impiegato entity)
        {
            bool risultato = false;
            try
            {
                if (impiegati.Find(i => i.Matricola == entity.Matricola).ToList().Count > 0) {
                    _logger.LogError("attenzione tentativo inserimento matricola duplicata");
                    return false;
            
                }
                this.impiegati.InsertOne(entity);
                risultato = true;

            }catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return risultato;
        }

        public bool Delete(int Id)
        {

            throw new NotImplementedException();
        }

        public bool Elimina(string varmatr)
        {
            bool risultato = false;
            try
            {
                var filter = Builders<Impiegato>.Filter.Eq("matr", varmatr);
                // impiegati.DeleteOne(filter);
                //var numeroCancellati =rDeletedCount;

                var result = impiegati.DeleteOne(filter);
                var numeroCancellati = result.DeletedCount;
                risultato = numeroCancellati > 0;
                //risultato = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return risultato;
        }
        //db.clienti.update(
//    {"cod_fis"::{$eq:"APPOPP"}
//}, 
//    {$set: { "nominativo":"Ciccio Pasticcio"} }
//)
        public bool Update(Impiegato entity)
        {
            bool risultato = false;
            try
            {
              
                var filter = Builders<Impiegato>.Filter.Eq("matr", entity.Matricola);
                var update = Builders<Impiegato>.Update
                    .Set("nomi", entity.Nominativo)  
                    .Set("dipa", entity.Dipartimento); 

                // Esegui l'aggiornamento
                var result = impiegati.UpdateOne(filter, update);

                // Controlla se l'aggiornamento è andato a buon fine
                var numeroAggiornati = result.ModifiedCount;
                //if (numeroAggiornati > 0)
                //    risultato = true;
                   
                risultato = numeroAggiornati > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return risultato;
        }


        public IEnumerable<Impiegato> GetAll()
        {
             return impiegati.Find(i => true).ToList();
        }

        public Impiegato? GetBYID(string varid)
        {
            throw new NotImplementedException();
        }

      
        public Impiegato? GetByMatricola(string matricola)
        {
            Impiegato? risultato = null;

            try
            {
                risultato = this.impiegati.Find(i => i.Matricola == matricola).FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return risultato;
        }
    }
}
