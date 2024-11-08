namespace Rest_08_Mongodb.Repos
{
    public interface IRepoLettura<T> 

    {
        T? GetBYID(string varid);
        IEnumerable<T> GetAll();
    }
}
