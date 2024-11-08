namespace A_CHAT.Repos
{
    public interface IRepoLettura<T>

    {
        T? Get(int id);
        IEnumerable<T> GetAll();
    
    }
}
