﻿using _05_eserciziocorsi.Models;
using _05_eserciziocorsi.Repos;
using Microsoft.Extensions.Logging;
using System.ComponentModel.Design;

namespace _05_eserciziocorsi.Services
{
    public class IscrizioneApiService : IServiceScrittura<IscrizioneDTO>
    {
        private readonly IscrizioneRepo _repo;
        private readonly CorsoService _corsoService;
        private readonly ILogger<IscrizioneApiService> _logger;

        public IscrizioneApiService(IscrizioneRepo repo, CorsoService corsoService, ILogger<IscrizioneApiService> logger)
        {
            _repo = repo;
            _corsoService = corsoService;
            _logger = logger;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

    

        public bool Update(IscrizioneDTO t)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IscrizioneDTO t)
        {
            if (t.CorsoIscr is null || t.CorsoIscr.Cod is null)
            {
                _logger.LogError("Le informazioni sul corso di destinazione sono incomplete");
                return false;
            }
            
            int? cRif = _corsoService.GetIdByCode(t.CorsoIscr.Cod);

            if (cRif is null)
            {
                _logger.LogError("Non è stato trovato l'ID del corso");
                return false;
            }


            Iscrizione iscr = new Iscrizione()
            {
                Codice = Guid.NewGuid().ToString().ToUpper(),
                Nome = t.Nome,
                Cognome = t.Cognome,
                Email = t.Email,
                DataIscr = DateTime.Now,
                CodiceDis = Guid.NewGuid().ToString().ToUpper(),
                CorsoRIF = (int)cRif
            };

            t.CodiceDis = iscr.CodiceDis;

            return _repo.Create(iscr);
        }
        public IscrizioneDTO? Cerca(string varCod)
        {
            IscrizioneDTO? risultato = null;

            Iscrizione? iscritto = _repo.CercaPerCodice(varCod);
            if (iscritto is not null)
            {
                risultato = new IscrizioneDTO()
                {
                    Codice = iscritto.Codice,
                    CodiceDis = iscritto.CodiceDis
                     

                };
            }

            return risultato;
        }

        //-----------------

        public IscrizioneDTO? Cercacanc(string varCod)
        {
            IscrizioneDTO? risultato = null;

            Iscrizione? iscritto = _repo.CercaPerCodice(varCod);
            if (iscritto is not null)
            {
                risultato = new IscrizioneDTO()
                {
                    Codice = iscritto.Codice,
                    CodiceDis = iscritto.CodiceDis


                };
            }

            return risultato;
        }
        public bool Delete(string codi)
        {
            bool risultato = false;

            Iscrizione? repo = _repo.GetByCodice(codi);
            if (repo is not null)
            {
                _repo.Eliminareisc(codi);
                risultato = true;
            }



            return risultato;


        }
    }
}
