using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama00_14122021
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int refValue = 5;//başlangıç değeri atanması zorunludur.
            int outValue;//başlangıç değeri atanması zorunlu değildir.

            OutMethod(out outValue, ref refValue);

            Console.WriteLine("OutMethod'dan sonra refValue : " + refValue); //Output 7
            Console.WriteLine("OutMethod'dan sonra outValue: " + outValue); //Output 8
            Console.ReadKey();
        }
        static void OutMethod(out int i, ref int j)
        {
            i = 8; // i argümanına bir değer atamak zorunludur
            j = j + 2; // j için böyle bir zorunluluk yoktur
        }
    }
}
