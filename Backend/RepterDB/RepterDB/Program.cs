using System.Text;

namespace RepterDB
{
    internal class Program
    {
        static Model.JaratContext jaratContext = new Model.JaratContext();
        static Dictionary<string, int> Varosok = new Dictionary<string, int>();

        static void LetrehozVaros()
        {
            foreach (KeyValuePair<string, int> kvp in Varosok)
            {
                if (jaratContext.Varosok.Where(x => x.Nev.Length == kvp.Key.Length).Any(x => x.Nev == kvp.Key))
                {
                    Console.WriteLine($"A {kvp.Key} nevű város már létezik!");
                }
                else
                {
                    Console.WriteLine($"A {kvp.Key} város létrehozva!");
                    jaratContext.Varosok.Add(new Model.Varos() { 
                        Nev = kvp.Key,
                        Nepesseg = kvp.Value,
                    });
                }
            }
            jaratContext.SaveChanges();
        }

        static void LetrehozJarat()
        {
            string JaratFilePath = @"C:\Users\nemet\Downloads\Jarat.txt";

            StreamReader sr2 = new StreamReader(JaratFilePath);
            while (!sr2.EndOfStream)
            {
                string[] temp1 = sr2.ReadLine().Split(';');
                jaratContext.Jatatok.Add(new Model.Jarat()
                {
                    Legitarsasag = temp1[0],
                    KiinduloVaros = jaratContext.Varosok.First(x => x.Nev == "Budapest"),
                    CelVaros = jaratContext.Varosok.First(x => x.Nev == "London"),
                    RepulesiIdo = Convert.ToInt32(temp1[3]),
                    Indulas = Convert.ToDateTime(temp1[4]),
                    KmDij = Convert.ToInt32(temp1[5]),
                    Atszallas = Convert.ToInt32(temp1[6]),
                });
            }
            sr2.Close();
            jaratContext.SaveChanges();
        }
        static void Main(string[] args)
        {
            string VarosFilePath = @"C:\Users\nemet\Downloads\Varos.txt";
            StreamReader sr = new StreamReader(VarosFilePath);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                Varosok.Add(temp[0], Convert.ToInt32(temp[1]));
            }
          
            LetrehozVaros();

            LetrehozJarat();

        }
    }
}