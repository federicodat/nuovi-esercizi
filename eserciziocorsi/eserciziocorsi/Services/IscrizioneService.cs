using eserciziocorsi.Models;
using eserciziocorsi.Repository;

namespace eserciziocorsi.Services
{
    public class IscrizioneService :IService<IscrizioneDTO>
    {
        private readonly IscrizioneRepo _repository;

        public IscrizioneService(IscrizioneRepo repository)
        {
            _repository = repository;
        }

        
        public IEnumerable<IscrizioneDTO> Lista()
        {
            throw new NotImplementedException();
        }

        public IscrizioneDTO? Cerca(string varCod)
        {
            throw new NotImplementedException();
        }

        
        public bool Inserisci(IscrizioneDTO iDto)
        {
            

            Iscrizione iscr = new Iscrizione()
            {

                codiscriz = iDto.codc is not null ? iDto.codc : Guid.NewGuid().ToString().ToUpper(),
                nome = iDto.Nom,
                cogn = iDto.Cog,
                mail = iDto.Ema,
                
                corsoRIF = 1 //proDto.cr
            };



 
            return _repository.Create(iscr);

        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Inserisci()
        {
            throw new NotImplementedException();
        }
    }
}
