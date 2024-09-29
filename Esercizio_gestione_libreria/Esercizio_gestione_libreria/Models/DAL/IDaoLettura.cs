using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_gestione_libreria.Models.DAL
{
    internal interface IDaoLettura<T>

    {
       
        List<T> GetAll();
        T? GetById(int id);
        
    }
}

