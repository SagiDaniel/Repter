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

            //Példa.
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
                    Indulas = new DateTime(2023,01,27,10,30,00),
                    Atszallas = 0,
                    KmDij = 1001.6,
                    Legitarsasag = new Legitarsasag
                    {
                        Nev = "WizzAir"
                    },
                    RepulesiIdo = 120,
                    CelVaros = new Varos()
                    {
                        Nev = "Bukarest",
                        Nepesseg = 1706851
                    },
                    KiinduloVaros = new Varos()
                    {
                        Nev = "Bécs",
                        Nepesseg = 1973403
                    }
                },
                new Jarat()
                {
                    Indulas = new DateTime(2023,02,01,15,00,00),
                    Atszallas = 0,
                    KmDij = 2000,
                    Legitarsasag = new Legitarsasag
                    {
                        Nev = "RyanAir"
                    },
                    RepulesiIdo = 200,
                    CelVaros = new Varos()
                    {
                        Nev = "London",
                        Nepesseg = 8908081
                    },
                    KiinduloVaros = new Varos()
                    {
                        Nev = "Madrid",
                        Nepesseg = 3280782
                    }
                },
                new Jarat()
                {
                    Indulas = new DateTime(2023,01,30,10,30,00),
                    Atszallas = 1,
                    KmDij = 5500,
                    Legitarsasag = new Legitarsasag
                    {
                        Nev = "BritishAir"
                    },
                    RepulesiIdo = 10,
                    CelVaros = new Varos()
                    {
                        Nev = "Miami",
                        Nepesseg = 439890
                    },
                    KiinduloVaros = new Varos()
                    {
                        Nev = "Párizs",
                        Nepesseg = 2165423
                    }
                },
                new Jarat()
                {
                    Indulas = new DateTime(2023,01,30,10,30,00),
                    Atszallas = 2,
                    KmDij = 6000,
                    Legitarsasag = new Legitarsasag
                    {
                        Nev = "BritishAir"
                    },
                    RepulesiIdo = 10,
                    CelVaros = new Varos()
                    {
                        Nev = "Frankfurt",
                        Nepesseg = 753056
                    },
                    KiinduloVaros = new Varos()
                    {
                        Nev = "Sydney",
                        Nepesseg = 4840600
                    }
                },
            };
            _context.AddRange(x);
            _context.SaveChanges();
        }
    }
}
