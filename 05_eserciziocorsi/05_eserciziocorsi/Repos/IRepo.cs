namespace _05_eserciziocorsi.Repos
{
    public interface IRepo<T>
    {
        T? Get(int id);
        IEnumerable<T> GetAll();
        bool Create(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
