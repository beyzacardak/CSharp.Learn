using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYonetim.Lib
{
    public class Bulasikci : Calisan
    {
        public Bulasikci(string isim, DateTime girisTarihi, Kafe kafe) : base(isim, girisTarihi, kafe)
        {
        }

        public void BulasikYika()
        {

        }

        public double MesaiUcreti { get; set; }
    }
}
