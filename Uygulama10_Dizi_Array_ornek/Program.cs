using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama10_13122021
{
    internal class Program
    {
        //Girilen N sayısından M sayısına kadar olan sayıların toplamı
        static void Main(string[] args)
        {

            int N, M, Toplam,i;
            Console.Write("N sayısını girin:");
            N=Convert.ToInt32(Console.ReadLine());
            Console.Write("M sayısını girin:");
            M = Convert.ToInt32(Console.ReadLine());
            Toplam = 0;
            //i = N;
            do
            {
                Toplam = Toplam + N;
                N++;
                Console.WriteLine("{0}, {1}:", N-1, Toplam);
            } while (N <= M);
            Console.Write("Toplam:{0}",Toplam);
            Console.ReadKey();

        }
    }
}
