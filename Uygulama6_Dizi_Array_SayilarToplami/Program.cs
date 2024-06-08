using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6_13122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen N adet sayının toplamını bulan program
             int N;
            Console.Write("Kaç adet sayı gireceksiniz:");
            N=Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[N];
            int Toplam = 0;
            //i++ --> i=i+1 i--> i=i-1
            //Sayılar dizisini oluşturdum.
            for (int i=0; i<sayilar.Length; i++)
            {
                Console.WriteLine("{0} inci sayıyı giriniz", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                Toplam += sayilar[i]; //Toplam=Toplam+sayilar[];
            }
            
            //Sayılar dizisini yazdıralım.
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0} inci sayı", sayilar[i]);
            }
            Console.WriteLine("Toplam: {0}", Toplam);
            Console.ReadKey();
        }
    }
}
