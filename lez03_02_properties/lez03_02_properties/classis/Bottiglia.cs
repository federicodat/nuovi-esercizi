using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_02_properties.classis
{
    internal class Bottiglia
    {
        public string? Materiale { get; set; }
		//propfull e+tab
		//private string? marca;

        //public string? Marca
        //{
        //	get { return marca; }
        //	set { marca = value; }
        //}
        public string? Marca { get; set; }


      private float altezza =0;

		public float  Altezza
		{
			get { return altezza; }
			set {
                if (value > 0)
                    altezza = value;
                else
                    Console.WriteLine("errore altezza");         

            }
        }

        private float diametro = 0;
        public float Diametro
        {
            get { return diametro; }
            set
            {
                if (value > 0)
                    diametro = value;
                else
                    Console.WriteLine("errore diametro");

            }
        }

        public float CalcolaVolume()
        {
            float raggio = diametro / 2;
            float area = (float)Math.PI * (raggio * raggio);
            return area * altezza;
        }
    


	}
}
