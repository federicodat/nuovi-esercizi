using lez04_03_statici.classes;

namespace lez04_03_statici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                       
            //Console.WriteLine(Studente.Contatore);

            Studente uno = new Studente();
            Studente due = new Studente();
            Studente tre = new Studente();

            //Studente.Contatore =55; non si può set è privat

            Console.WriteLine(Studente.getContatore());



        }
    }
}
