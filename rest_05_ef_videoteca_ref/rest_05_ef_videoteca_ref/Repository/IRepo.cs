namespace rest_05_ef_videoteca_ref.Repository
{
    public interface IRepo<T>

    {
        IEnumerable<T> GetAll();    
        T? Get(int id); 
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);

    }
}
