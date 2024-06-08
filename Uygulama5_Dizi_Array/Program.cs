using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Uygulama5_1312021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Gösterimi-1
            //int[] sayilar2 =  {13, 24, 65, 78, 37, 98};
            //Dizi Gösterimi-2
            int[] sayilar = new int[6];
            int Toplam = 0;
            sayilar[0] = 13;
            sayilar[1] = 24;
            sayilar[2] = 65;
            sayilar[3] = 78;
            sayilar[4] = 37;
            sayilar[5] = 98;

            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
                //Toplam = Toplam + i;
                Toplam += i;
            }
            Console.WriteLine("Sayılar Toplamı:{0}", Toplam);

            Toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
                //Toplam = Toplam + i;
                Toplam += sayilar[i];
            }
            Console.WriteLine("Sayılar Toplamı:{0}", Toplam);
            Console.ReadKey();

            
        }
    }
}
