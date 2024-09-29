namespace lez02_02_contenitori_semplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] elenco = { 1, 2, 55, 60, 44 };
            //elenco[2] = 77;
            //Console.WriteLine(elenco[0]);
            //Console.WriteLine(elenco[1]);
            //Console.WriteLine(elenco[2]);
            //Console.WriteLine(elenco[3]);
            //------------------  allocaun contenitore 5 slot 

            //int[] elencodue = new int[5];
            //elencodue[0] = 23;
            //elencodue[1] = 33;
            //elencodue[2] = 44;
            //elencodue[3] = 55;
            //elencodue[4] = 66;
            //elencodue[5] = 77;  // con questo va in ower flow

            //Console.WriteLine(elencodue.Length);

            //int i = 0;
            ////int max = elencodue.Length;

            //while (i < elencodue.Length)
            //{
            //    Console.WriteLine(elencodue[i]);
            //    i++;
            //        }

            //string[] elenco3 = { "feee", "ggg" };
            //int i = 0;

            //while (i < elenco3.Length)
            //{
            //    Console.WriteLine(elenco3[i]);
            //    i++;
            //}

            //string[] elenco3 = { "BMW", "FIAT" ,"LAMBOGHINI"};
            //int i = 0;
            //int contatore = 0;

            //while (i < elenco3.Length)
            //{
            //    if (elenco3[i].Equals("FIAT"))
            //        contatore++;

            //    i++;
            //}

            //Console.WriteLine(contatore);

            //string[] elenco3 = { "BMW", "FIAT","AUDI" ,"LAMBOGHINI" };
            //int i = 0;
            ////int contatore = 0;

            //Array.Sort(elenco3);

            //while (i < elenco3.Length)
            //{
            //    Console.WriteLine(elenco3[i]);
            //    i++;
            //}     

            //string[] garage = { "BMW", "FIAT","AUDI" ,"LAMBOGHINI" };
            ////int i = 0;
            ////int contatore = 0;

            //Array.Sort(garage);

            //foreach(string auto in garage) 
            //{

            //    Console.WriteLine(auto);
            // }

            //-------------------------------
            //string invitati =  "mario-gianni-pippo-luca";
            //string[] arrayinvitati = invitati.Split('-');
            //int i = 0;
            //while (i < elenco3.Length)

            //{

            //    Console.WriteLine(persona[0]);                            //1 lettera
            //    Console.WriteLine(persona[persona.Length -1]);             // ultima lettera
            //}

            //-----------------


            string[] garage = { "BMW", "FIAT", "AUDI", "LAMBOGHINI" };

            //int i = 0;
            //while (i < garage.Length)
            //{

            //    Console.WriteLine(garage[i]);
            //    i++;

            //}
            //for simile struttura while
            for (int i = 0; i < garage.Length; i++) {
                Console.WriteLine(garage[i]);
            }


            //---------fine
        }
    }
}
