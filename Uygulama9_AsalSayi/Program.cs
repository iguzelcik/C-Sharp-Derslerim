using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9_13122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen Sayı Asal mı?
            int sayi, i, sonuc;
            Console.Write("Sayı Giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            i = sayi-1;
            sonuc = 0;
            //  % operatörü bir sayının bölümünden kalanı verir.
            // != eşit değil        
            do
            {
                if (sayi % i == 0)
                {
                    sonuc++;
                }
                i--; 
                

            } while (i >= 0);
            
            //while (i>=2) //olduğu sürece
            //{ 
            //    if (sayi % i == 0)
            //    {
            //        sonuc++;
            //    }
            //    i--; //i=i+1
            //    //sonuc=sonuc+1
            //}
            if (sonuc>0)
            {
                Console.WriteLine("Sayı Asal Değil");
            }
            else
            {
                Console.WriteLine("Sayı Asal");
            }

            Console.ReadKey();
        }
    }
}
