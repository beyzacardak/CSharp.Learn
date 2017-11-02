using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelimeara
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = Console.ReadLine();
            var belirle = metin.Split(new[] { '.',',',' ' });
            string[] bulunan = new string[metin.Length];

            int sayi = 0;
            for (int i = 0; i < belirle.Length; i++)
            {
                for (int j = 0; j < belirle.Length; j++)
                {
                    if(belirle[i]==belirle[j])
                    {
                        sayi++;
                    }
                   
                }
                Console.WriteLine(sayi);
                sayi = 0;

            }
           
            Console.ReadLine();
        }
    }
}
