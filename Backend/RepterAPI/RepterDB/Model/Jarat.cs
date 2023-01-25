namespace RepterAPI.Infrastructure.Model
{
    public class Jarat
    {
        public int Id { get; set; }
        public Legitarsasag Legitarsasag { get; set; }
        public Varos KiinduloVaros { get; set; }
        public Varos CelVaros { get; set; }
        public int RepulesiIdo { get; set; }
        public DateTime Indulas { get; set; }
        public double KmDij { get; set; }
        public int Atszallas { get; set; }
    }
}
