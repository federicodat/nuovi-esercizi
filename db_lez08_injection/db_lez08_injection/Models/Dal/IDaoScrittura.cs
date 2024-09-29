using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez08_injection.Models.Dal
{
    internal interface IDaoScrittura<T>

    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t);
    }
}
