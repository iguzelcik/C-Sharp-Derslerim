using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama0_14122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orjinalDeger = 43; // ref kullanırkan başlangıç değer zorunlu

            Console.WriteLine("RefMethod'dan önce: " + orjinalDeger);//Output 43

            RefMethod(1, 3, ref orjinalDeger);
            RefMethod2(1, 3,  orjinalDeger);
            Console.WriteLine("RefMethod'dan sonra: " + orjinalDeger); //Output 47
            Console.ReadKey();
        }
        static void RefMethod(int x, int y, ref int i)
        {
            i = i + x + y;//47
        }

        static void RefMethod2(int x, int y,  int i)
        {
            i = i + x * y;//47
        }
    }
}
