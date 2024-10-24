using rest_03_ef_ferramenta.Models;

namespace rest_03_ef_ferramenta.repository.Service
{
    public class ProdottoService
    {
        {
        private static ProdottoService? instance;

        public static ProdottoService GetInstance()
        {
            if (instance == null)
                instance = new ProdottoService();

            return instance;
        }
        private ProdottoService() { }

        public ProdottoDTO? Cerca(string varCodice) 
        { 
        ProdottoDTO? prod =ProdottoRepository.GetInstance().GetByCodiceBarre(varCodice);

            if (prod is not null)
            { ProdottoDTO risu=new ProdottoDTO()
                    cod=prod.CodiceBarre;
                     =
            }
                

        }

    }
}
