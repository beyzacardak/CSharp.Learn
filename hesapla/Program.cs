using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapla
{
    class Program
    {
        static void Main(string[] args)
        {
           
           

            char karar = 'e';
            
            do
            {
                Console.WriteLine("yapmak istediğiniz işlemi giriniz:");

                var islem = Console.ReadLine();


                var sonuc = islem.Split(new[] { '+', '-', '*', '/' });

                char opt = '+';

                for (int i = 0; i < islem.Length; i++)
                {
                    if (islem[i] == '+' || islem[i] == '-' || islem[i] == '*' || islem[i] == '/')
                    {
                        opt = islem[i];
                    }
                }

                if (opt=='+')
                {
                    Console.WriteLine("sonuç: " +(int.Parse( sonuc[0]) + int.Parse(sonuc[1])));
                }
                else if (opt == '-')
                {
                    Console.WriteLine("sonuç: " + (int.Parse(sonuc[0]) - int.Parse(sonuc[1])));
                }
                else if (opt == '*')
                {
                    Console.WriteLine("sonuç: " + (int.Parse(sonuc[0]) * int.Parse(sonuc[1])));
                }
                else if (opt == '/')
                {
                    Console.WriteLine("sonuç: " + (int.Parse(sonuc[0]) / int.Parse(sonuc[1])));
                }
                Console.WriteLine("devam etmek istiyor musunuz? (E/H)");
                karar = char.Parse(Console.ReadLine());
            } while (karar == 'E' || karar == 'e');
            

           
        }
    }
}
