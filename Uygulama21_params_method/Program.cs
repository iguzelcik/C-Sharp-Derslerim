using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5_14122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = SayilariTopla(5);
            int result2 = SayilariTopla(1, 2, -3);
            int result3 = SayilariTopla(-4, 4, 3, 7, -7, 1, 8, 0);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            MetinYazdir();
            MetinYazdir("merhaba");
            MetinYazdir("merhaba", "ilker");  
            MetinYazdir("merhaba", "arkadaşlar", "hepiniz", "hoşgeldiniz"); 
            Console.ReadKey();
        }
        public static int SayilariTopla(params object[] sayilar)
        {
            int toplam = 0;
            foreach (int i in sayilar)
            {
                toplam += i;
            }
            return toplam;
        }

        public static void MetinYazdir(params string[] kelimeler)
        {
            if (kelimeler.Length.Equals(0)) //Equals eşit mi olarak kullanılıyor.
                Console.WriteLine("hiç parametre yok");
            else
            {
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    Console.Write(kelimeler[i] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
