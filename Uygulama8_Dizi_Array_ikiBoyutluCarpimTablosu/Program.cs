using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8_13122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iki boyutlu 10x10 elemanlı bir dizi tanımladık
            int[,] carpimTablosu = new int[10, 10];

            //
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    carpimTablosu[i-1, j-1] = (i) * (j);
                    Console.WriteLine("{0} X {1} = {2} ", i, j, carpimTablosu[i-1, j-1]);
                }
            }
            Console.ReadKey();
        }
    }
}
