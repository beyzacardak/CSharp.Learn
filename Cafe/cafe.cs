using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeYonetimi.lib

{
    public class Cafe
    {
        public string Ad{ get; private set; }
        public string AcilisSaati { get; private set; }
        public string KapanisSaati { get; private set; }
        public CafeDurum Durum { get; set; }
        public Urun[] Urunler { get; set; }
        public void Ac()
        {
            Durum = CafeDurum.Acik;
        }
        public void Kapa()
        {
            Durum = CafeDurum.Kapali;
        }

    }
}
