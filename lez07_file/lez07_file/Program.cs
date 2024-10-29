namespace lez07_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\federico.dattilo\\source\\prova.txt";
            #region scrittura
            //string contenuto = "ciao sono fede";

            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(path))
            //    {

            //        sw.WriteLine("ettttt");
            //        sw.WriteLine("yyyyyy");

            //        sw.Close();
            //    };

            //}catch (Exception ex) {Console.WriteLine(ex);}
            #endregion  scrittura

            try
            { 
                using(StreamReader sr = new StreamReader(path)) {
                    string? line;

                    while((line = sr.ReadLine()) != null)
                        { 
                        Console.WriteLine(line);    
                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); }    
        }
    }
}
