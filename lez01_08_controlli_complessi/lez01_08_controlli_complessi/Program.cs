namespace lez01_08_controlli_complessi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //dato input sigla provincia  voglio sapere il nome esteso

            string provincia = "Be";

            //if (provincia.Equals("BO"))
            //Console.WriteLine("Hello, World!");


            // SWITCH CASE
            switch (provincia)
            { case "AQ":
                    Console.WriteLine("L'AQUILA");
                    break;
                case "BO":
                    Console.WriteLine("BOLOGNA");
                    break;
                default:
                    Console.WriteLine("non trovato");
                    break;
            }
                    //end
            }
    }
}
