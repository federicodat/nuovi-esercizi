namespace Linw_lez01_filtrinumeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>   elenco= new List<int>() {1,4,6,7,8,9,4,11 };
            var risultato =  from numero in elenco
                             where numero > 5
                             orderby numero                               select numero;



            foreach (var num in risultato)
            {    

             Console.WriteLine(num);
            }
        }
    }
}
