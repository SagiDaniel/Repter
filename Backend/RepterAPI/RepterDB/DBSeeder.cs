using RepterAPI.Infrastructure.Model;

namespace RepterAPI.Infrastructure
{
    public class DBSeeder
    {
        private DBContext _context;
        public DBSeeder(DBContext context)
        {
            _context = context;
        }

        public void InitDatabase()
        {
            if (_context.Varosok.Any())
            {
                return;
            }

            // A követendő jópélda.
            /*List<Varos> varos = new List<Varos>();
            varos.Add(new Varos()
            {
                Nev = "Budapest",
                Nepesseg = 1000000
            });
            _context.Varosok.AddRange(varos);
            _context.SaveChanges();*/

            var x = new Jarat[]
            {
                new Jarat()
                {
                    Indulas = new DateTime(2023,01,25,10,30,00),
                    Atszallas = 0,
                    KmDij = 1001.6,
                    Legitarsasag = new Legitarsasag
                    {
                        Nev = "MALÉV"
                    },
                    RepulesiIdo = 10,
                    CelVaros = new Varos()
                    {
                        Nev = "Bukarest",
                        Nepesseg = 2000000
                    },
                    KiinduloVaros = new Varos()
                    {
                        Nev = "Bukarest",
                        Nepesseg = 2000000
                    }
                }
            };
            _context.AddRange(x);
            _context.SaveChanges();
        }
    }
}
