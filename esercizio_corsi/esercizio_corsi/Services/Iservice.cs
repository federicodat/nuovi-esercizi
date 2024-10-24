namespace esercizio_corsi.Services
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
