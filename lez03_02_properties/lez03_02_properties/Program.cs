using lez03_02_properties.classis;

namespace lez03_02_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// metodo property
            Bottiglia acqua = new Bottiglia();
            acqua.Materiale = "Pet";
            acqua.Marca = "santa lucia";
            acqua.Altezza = 10f;
            acqua.Diametro = 11f;



            Console.WriteLine(acqua.Materiale);

            Console.WriteLine(acqua.Marca);

            Console.WriteLine(acqua.CalcolaVolume());

            //---------------
            //Console.WriteLine("Hello, World!");
        }
    }
}
