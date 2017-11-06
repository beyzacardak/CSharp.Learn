using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binaa;
namespace BinaYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaModel binamodel = new BinaModel();
            binamodel.Ad = "vuslat";
            binamodel.Renk = "beyaz";

            Console.WriteLine($"Binanın Adı: {binamodel.Ad /*+ binamodel.Renk*/}");
            Console.ReadKey();
        }
    }
}
