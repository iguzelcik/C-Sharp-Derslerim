using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama7_1312021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Kaç adet sayı gireceksiniz:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[N];
            int ENB;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0} inci sayıyı giriniz", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            //65,76,8,97,4
            ENB = sayilar[0];
            
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (ENB > sayilar[i])
                {
                    //
                }
                else
                {
                    ENB=sayilar[i]; //97
                }
            }
            Console.WriteLine("{0} en büyük dizi elemanı", ENB);
            Console.ReadKey();
        }
    }
}
