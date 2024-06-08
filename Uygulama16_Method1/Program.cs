using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_14122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeşekkürEt("İlker");

            double k1, k2, s;
            Console.Write("1. Kenar");
            k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Kenar");
            k2 = Convert.ToDouble(Console.ReadLine());
            s = Hipotenus(k1, k2);
            Console.WriteLine("Hipotenüs: {0}", s);
            BugununTarihiniYaz();
            double puan1 = BasariPuani(45, 55, 65);
            double puan2 = BasariPuani(68, 99, 45,75);
            Console.Write("Puan1: {0} \n", puan1);
            Console.Write("Puan2: {0} \n", puan2);
            Console.ReadKey();
        }

        static double Hipotenus(double kenar1, double kenar2)
        {
            double sonuc;
            sonuc=Math.Sqrt(Math.Pow(kenar1,2)+Math.Pow(kenar2,2));
            return sonuc;
        }
        //parametre alan geriye değer döndürmeyen
        static void TeşekkürEt(string isim)
        {
            Console.WriteLine("Teşekkürler {0}", isim);
        }

        //parametre almayan ve geriye değer döndürmeyen method
        public static void BugununTarihiniYaz()
        {
            Console.WriteLine("Bugünün Tarihi: {0}", DateTime.Now.ToString());
        }

        //parametre alan ve geriye değer döndüren
        public static double BasariPuani(double vize1, double vize2, double final)
        {
            double sonuc = vize1 * 0.3 + vize2 * 0.3 + final * 0.4;
            return sonuc;
        }

        //BasariPuani method'u overloading 
        public static double BasariPuani(double vize1, double vize2, double final, double sozlu)
        {
            double sonuc = vize1 * 0.25 + vize2 * 0.25 + final * 0.3 + sozlu * 0.2;
            return sonuc;
        }

        //parametre alan ve geriye değer döndüren
        public static string BasariDurumu(double puan)
        {
            string sonuc;
            if (puan < 45)
            {
                sonuc = "F";
            } else if (puan < 55)
            {
                sonuc = "D";
            }
            else if (puan < 70)
            {
                sonuc = "C";
            }
            else if (puan < 85)
            {
                sonuc = "B";
            }
            else
            {
                sonuc = "A";
            }
            return sonuc;
        }
        //parametre almayan geriye değer döndüren
        public string BaşarıMesajı()
        {
            string Mesaj = "Başarılar Dileriz";
            return Mesaj;
        }
    }
}
