using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringcalsma
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = Console.ReadLine();
            //metin = metin.Replace(".", "").Replace(",", "").Replace("'", "").Replace("\"", "").Replace("?", "").Replace("!", "");
            var kelimeler = metin.Split(new[] {' ','.',',','?','!' });


            string uzunkelime = "";
            foreach(var kelime in kelimeler)
            {
                if(kelime.Length >uzunkelime.Length)
                {
                    uzunkelime = kelime;
                }
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
