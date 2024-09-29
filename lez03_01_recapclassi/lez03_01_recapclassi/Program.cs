using lez03_01_recapclassi.classi;
using System.Security.AccessControl;

namespace lez03_01_recapclassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

              Bottiglia acqua = new Bottiglia();
              acqua.SetAltezza(15.8f);
             Console.WriteLine(acqua.GetAltezza());

            Console.WriteLine(
                acqua.CalcolaVolume());

          //  --ffff
        }

       

    }
}
