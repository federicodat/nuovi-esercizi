﻿namespace Rest_08_Mongodb.Repos
{
    public interface IRepoScrittura <T>
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int  Id);
         
    }
}

     
 