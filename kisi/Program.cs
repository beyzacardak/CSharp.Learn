using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            //do
            //{
            //    Console.WriteLine("isim giriniz");
            //     isim = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(isim))
            //    {
            //        Console.WriteLine("hatalı metin");
            //        break;
            //    }

            //} while (string.IsNullOrWhiteSpace(isim));
            do
            {
                Console.WriteLine("isim giriniz");
                isim = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(isim))
                {
                    
                    break;
                }
                Console.WriteLine("hatalı metin");

            } while (true);
            Console.ReadKey();
            
            //Console.ReadLine();
        }
    }
}
