namespace lez07_file
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\Users\\federico.dattilo\\source\\persona.csv";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string? line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
