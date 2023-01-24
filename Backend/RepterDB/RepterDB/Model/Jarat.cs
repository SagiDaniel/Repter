using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepterDB.Model;

namespace RepterDB.Model
{
    public class Jarat
    {
        public int ID { get; set; }
        public string Legitarsasag { get; set; }
        public virtual Varos KiinduloVaros { get; set; }
        public virtual Varos CelVaros { get; set; }
        public int RepulesiIdo { get; set; }
        public DateTime Indulas { get; set; }
        public double KmDij { get; set; }
    }
}
