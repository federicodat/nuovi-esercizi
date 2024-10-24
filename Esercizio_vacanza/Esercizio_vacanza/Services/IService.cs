namespace Esercizio_vacanza.Services
{
    public interface IService <T>

    {
        IEnumerable<T> Lista();
        IEnumerable<T> Listadespac(string varCodice);
     
        T? Cerca(string varCod);
        bool Inserisci();
        bool Delete();
        bool Update();
    }
}
