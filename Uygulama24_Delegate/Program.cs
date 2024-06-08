using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3_15122021_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler(Cikar);
            int hesap = islemler(300, 44);
            Console.WriteLine(hesap);
            Console.ReadKey();

        }

        // Delege oluşturuyoruz
        public delegate int Islemler(int ilkSayi, int ikinciSayi);

        // 4 temel işlemi gerçekleştiriyoruz
        public static int Topla(int a, int b)
        {
            return a + b;
        }
        public static int Cikar(int a, int b)
        {
            return a - b;
        }
        public static int Carp(int a, int b)
        {
            return a * b;
        }
        public static int Bol(int a, int b)
        {
            return a / b;
        }
    }
}
