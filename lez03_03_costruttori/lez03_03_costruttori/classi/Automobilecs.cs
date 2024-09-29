using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_03_costruttori.classi
{
    internal class Automobilecs
    {
        public string Marca { get; set; } = null!;
        public int Cilindrata { get; set; } = 0;
        public string Colore { get; set; } = null!;

    //    public Automobilecs()



        public Automobilecs(string varMarca, int varCilindrata, string varColore)
        {
          this.Marca = varMarca ;
            this.Cilindrata =varCilindrata;
            this.Colore=varColore;


           // Console.WriteLine("Hello, World!");
        }

        public void Stampadettaglio()
        {
            Console.WriteLine($"[Automobile] {Marca} {Cilindrata} {Colore}");
        }
        public override string ToString()
        {
            return $"[Automobile] {Marca} {Cilindrata} {Colore}";
        }
    }


}
