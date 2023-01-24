using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepterDB.Model;

namespace RepterDB.Model
{
    public class Varos
    {
        public int ID { get; set; }
        public string Nev { get; set; }
        public int Nepesseg { get; set; }
        public virtual ICollection<Jarat> JaratokInnen { get; set; }
    }
}
