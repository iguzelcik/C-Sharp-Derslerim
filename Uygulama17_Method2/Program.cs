using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_1_14122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s1, s2;
            Console.Write("1.Sayıyı Giriniz:");
            s1=Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz:");
            s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplam: {0}", Topla(s1, s2));
            Merhaba("ilker");
            Console.ReadKey();
        }

        //parametre girilen ve değer döndürülen method
        static double Topla(double say1, double say2)
        {
            return say1+say2;
        }
        //parametre girilen ve değer döndürmeyen method, değer döndürmediği için return kullanılmaz 
        static void Merhaba(string isim)
        {
            Console.WriteLine("Merhaba {0}", isim);
        }
    }
}
