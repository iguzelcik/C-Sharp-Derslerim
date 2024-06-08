using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4_14122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Faktöryel (For Döngüsü ile): {0}", FaktoriyelForDongusu(sayi));
            Console.WriteLine("Faktöryel (Recursive Method ile): {0}", FaktoriyelRecursive(sayi));
            Console.WriteLine("Topla (Recursive Method ile): {0}", ToplaRecursive(sayi));
            Console.ReadLine();
        }
        private static int FaktoriyelForDongusu(int sayi)
        {
            int fakt = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }

        private static int FaktoriyelRecursive(int sayi)
        {
            if (sayi == 0) return 1; else return sayi * FaktoriyelRecursive(sayi - 1);
        }

        static int ToplaRecursive(int sayi)
        {
            if (sayi == 0) return 0; else return sayi + ToplaRecursive(sayi - 1);
        }
    }
}
