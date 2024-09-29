using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_lez08_injection.Models.Dal
{
    internal interface IDaoLettura<T>

    {
        List<T> GetAll();
        T Get(int id);  

    }
}
