﻿namespace A_CHAT.Services
{
    public interface IServiceScrittura<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
