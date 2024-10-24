namespace rest_05_ef_videoteca_ref.services
{
    public interface IService<T>
    {
        IEnumerable<T> Lista();
        T? Cerca(string varCod);
    }
}
