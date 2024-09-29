using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_gestione_libreria.Models.DAL
{
    internal interface IDaoscrittura<T>
    {
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(int id);
    }
}
