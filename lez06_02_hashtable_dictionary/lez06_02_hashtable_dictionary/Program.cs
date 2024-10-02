using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace lez06_02_hashtable_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Hashtable ht = new Hashtable(); 

            //ht.Add(0, "gianni");
            //ht.Add(1, "mario");
            //ht.Add("pippo", "valerio");
            //ht.Add(0.4f, "pippo");
            //ht.Add("mario", 0.5d);
            //ht.Add("lista",new List<string>() {"bmw" , "audi" });



            ////Console.WriteLine(ht["pippo"]);
            ////Console.WriteLine(ht[1]);
            ////Console.WriteLine(ht["lista"]);

            ////if(ht.ContainsKey ("Pippo"))

            ////    Console.WriteLine(ht["pippo"]);

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            //-----Dictionary --

            //Dictionary<int,string> combina = new Dictionary<int,string>();

            //combina.Add(0, "giann");    
            //combina.Add(2, "mario");
            //foreach (KeyValuePair< int,string> f  in combina )
            //{
            //    Console.WriteLine(f.Key);
            //    Console.WriteLine(f.Value);
                
            //}
            //foreach (int k in combina.Keys  )
            //{
            //    Console.WriteLine(k);
              
                
            //}

//---------------------------------
     

            Hashtable gatto = new Hashtable();
            gatto.Add("razza", "europeo");
            gatto.Add("nome", "bu");

            Hashtable ht2 = new Hashtable();
            ht2.Add("nome", "gianni");
            ht2.Add("cognome", "pace");
            ht2.Add("eta", 37);
            ht2.Add("animale", gatto);

            foreach (DictionaryEntry dett in ht2)
            {
                //Console.WriteLine(ht2.Key);
               //  vedi esempio prof
            }



        }
    }
}