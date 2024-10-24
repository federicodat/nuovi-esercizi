using EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;

namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Repository
{
    public class ProdottoRepo : IRepo<Prodotto>
    {
        private readonly BrugoliamoContex _context;

        public ProdottoRepo(BrugoliamoContex context)
        {
            _context = context;
        }


        public bool Eliminarep(string cod)
        {

            bool risultato = false;

            Prodotto? prodo = GetByCodice(cod);

            if (prodo is not null)

                try
                {
                    _context.Prodotti.Remove(prodo);

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

        public Prodotto? GetByCodice(string cod)
        {
            return _context.Prodotti.FirstOrDefault(p => p.CodiceBarre == cod    );
        }
        public IEnumerable<Prodotto> GetAll()
        {
            return _context.Prodotti.ToList();
        }
        public bool Update(Prodotto entity)
        {
            try
            {
                _context.Prodotti.Update(entity);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }



        public Prodotto? Get(int id)
        {
            return _context.Prodotti.Find(id);
        }



        //public bool Create(Prodotto entity,Reparto varcod)
        public bool Create(Prodotto entity  )
         
        {
            //bool risultato = false;
            //if (varcod is not null)
            //{
                //Reparto? repo = GetByCodice(varcod);

              //  if (repo is not null)
                    try
                    {
                        _context.Prodotti.Add(entity);

                        _context.SaveChanges();

                        return true;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                        return false;
                    }


            //}
           // return risultato;

            
        }

        private Reparto? GetByCodice(Reparto cod)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        //public bool Create(Prodotto entity)
        //{
        //    throw new NotImplementedException();
        //}



        //internal static object GetInstance()
        //{
        //    throw new NotImplementedException();
        //}


    }
        }

