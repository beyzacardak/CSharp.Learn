using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeYonetimi.lib
{
   public class Siparis
    {
        public int Siparisno{ get; private set; }
        public Kalem[] Kalemler { get; set; }
        public Garson SiparisAlanGArson { get; set; }
        public Asci SiparisiHazirlayanAsci { get; set; }
        public string not;

    }
}
