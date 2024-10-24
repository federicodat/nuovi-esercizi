namespace _05_eserciziocorsi.Services
{
    public interface IServiceLettura<T>
    {
        IEnumerable<T> List();
        T? Details(int id);
    }
}