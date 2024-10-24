using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Repository
{
    public class RepartoRepo : IRepo<Reparto>
    {
        private readonly BrugoliamoContex _context;

        public RepartoRepo(BrugoliamoContex context)
        {
            _context = context;
        }
     


        public bool Eliminarep(string cod)
        {
            
                bool risultato = false;

                Reparto? repo = GetByCodice(cod);

            if (repo is not null)

                try
                {
                    _context.Reparti.Remove(repo);

                    _context.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return false;
                }
             

            return risultato;
            
        }

   
        public Reparto? GetByCodice(string cod)
        {
            return _context.Reparti.FirstOrDefault(r => r.repartoCOD == cod);   
               }
        public IEnumerable<Reparto> GetAll()
        {
            return _context.Reparti.ToList();
        }
        public bool Update(Reparto entity)
        {
            try
            {
                _context.Reparti.Update(entity);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }



        public Reparto? Get(int id)
        {
            return _context.Reparti.Find(id);
        }

      

        public bool Create(Reparto entity)
        {
            try
            {
                 _context.Reparti.Add(entity);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        //internal static object GetInstance()
        //{
        //    throw new NotImplementedException();
        //}


    }
}
