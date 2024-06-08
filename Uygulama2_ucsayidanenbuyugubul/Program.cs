using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2_13122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 sayıdan en büyüğünü bulmak
            int say1, say2, say3;
            Console.WriteLine("1. sayıyı giriniz:");
            say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            say2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayıyı giriniz:");
            say3 = Convert.ToInt32(Console.ReadLine());
            // && AND (VE)

            if (say1>say2 && say1 > say3)
            {
                Console.WriteLine("Büyük sayı: {0}", say1);

            }
            else
            {
                if (say2 > say3)
                {
                    Console.WriteLine("Büyük sayı: {0}", say2);
                }
                else
                {
                    Console.WriteLine("Büyük sayı: {0}", say3);
                }
            }

            Console.ReadKey();
        }
    }
}
