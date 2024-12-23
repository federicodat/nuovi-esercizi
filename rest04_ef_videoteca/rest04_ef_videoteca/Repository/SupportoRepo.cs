﻿using rest04_ef_videoteca.Models;

namespace rest04_ef_videoteca.Repository
{
  
        public class SupportoRepo : Irepo<Supporto>
        {
            private static SupportoRepo? instance;

            public static SupportoRepo GetInstance()
            {
                if (instance == null)
                    instance = new SupportoRepo();

                return instance;
            }
            private SupportoRepo() { }

            public bool Delete(int id)
            {
                bool risultato = false;

                using (var ctx = new EfLez04VideotecheContext())
                {
                    try
                    {
                        Supporto lib = ctx.Supportos.Single(l => l.SupportoId == id);
                        ctx.Supportos.Remove(lib);
                        ctx.SaveChanges();

                        risultato = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                return risultato;
            }

            public List<Supporto> GetAll()
            {
                List<Supporto> elenco = new List<Supporto>();

                using (var ctx = new EfLez04VideotecheContext())
                    elenco = ctx.Supportos.ToList();

                return elenco;
            }

            public Supporto? GetById(int id)
            {
                Supporto? risultato = null;

                using (var ctx = new EfLez04VideotecheContext())
                    risultato = ctx.Supportos.FirstOrDefault(l => l.SupportoId == id);

                return risultato;
            }

            public Supporto? GetByCodice(string varCodice)
            {
                Supporto? risultato = null;

                using (var ctx = new EfLez04VideotecheContext())
                    risultato = ctx.Supportos.FirstOrDefault(l => l.Codice == varCodice);

                return risultato;
            }

            public bool Insert(Supporto t)
            {
                bool risultato = false;

                using (var ctx = new EfLez04VideotecheContext())
                {
                    try
                    {
                        ctx.Supportos.Add(t);
                        ctx.SaveChanges();

                        risultato = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                return risultato;
            }

            public bool Update(Supporto t)
            {
                throw new NotImplementedException();
            }
        }
    }