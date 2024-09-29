using Lez03_09_poli.classes;
using System.Reflection.Metadata.Ecma335;

namespace lez03_09_poli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Veicolo auto = new Auto();
            //Veicolo mot = new Moto();
            //           Auto focus = new Auto();
            //Auto panda = new Auto();

            //Moto honda = new Moto();
            //Moto ducati = new Moto();

            //List<Auto> lista = new List<Auto>();
            //List<Moto> lista = new List<Moto>(


                Veicolo focus = new Auto();    
                Veicolo panda = new Auto();   
        
                Veicolo honda = new Moto();    
                Veicolo ducati = new Moto();    

           List<Veicolo> elenco = new List<Veicolo>(); 
            elenco.Add(focus);
            elenco.Add(panda);
            elenco.Add(honda);
            elenco.Add(ducati);
         
            foreach(Veicolo vei in elenco)
                        
            {
                vei.Accensione();                 
                //Console.WriteLine(Veicolo.ToString());
                    
             }
    }
}
