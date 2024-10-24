namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Services
{
    public interface IService<T>
    {
        IEnumerable<T> Lista();
        T? Cerca(string varCod);
        bool Inserisci();
        bool Delete();
        bool Update();
    }
}
