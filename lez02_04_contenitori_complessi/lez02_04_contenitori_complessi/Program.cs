namespace lez02_04_contenitori_complessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
             

            string[]    gio = {"giovanni", "pace", "ab1234" ,"44"};
            string[]    val = {"valeria", "rossi", "cc1234","33" };
            string[]    fra = {"franco", "verde", "gg1534" ,"55"};

            List<string[]> elenco = new List<string[]>();
            elenco.Add(gio);
            elenco.Add(val);
            elenco.Add(fra);

            //for (int i = 0; i < elenco.Count; i++)
            //{
            //Console.WriteLine(elenco[i][2]);


            for (int i = 0; i < elenco.Count; i++)
            {
                for (int k = 0; k < elenco[i].Length; k++)
                    Console.WriteLine(elenco[i][k]);
            }

        

        //------------end
    }
    }
}
