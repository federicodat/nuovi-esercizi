using db_lez05_calcolatrice_singleton.classes;

namespace db_lez05_calcolatrice_singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             
            //Console.WriteLine(Calcolatrice.Somma (5,3));
            Console.WriteLine(Calcolatrice.GetInstance().Somma(3,4));
            Console.WriteLine(Calcolatrice.GetInstance().Moltiplicazione(3,4));
            Console.WriteLine(Calcolatrice.GetInstance().Divisione(3,4));
            Console.WriteLine(Calcolatrice.GetInstance().Sottrazione(3,4));
        }
    }
}
