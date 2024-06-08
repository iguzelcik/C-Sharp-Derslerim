using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama11_13122021
{ 
    internal class Program
    {
        //Kullanıcı adı ve şifreyi doğru girene kadar döngü devam etsin.
        static void Main(string[] args)
        {
            string kullaniciAdi, sifre;
            int i;
            //kullaniciAdi = "Admin";
            //sifre = "1234";
            i = 0;

            do
            {

                Console.Write("Kullanıcı Adı Giriniz:");
                kullaniciAdi = Console.ReadLine();
                Console.Write("Şifre Giriniz:");
                sifre = Console.ReadLine();
                if (kullaniciAdi == "Admin" && sifre == "1234")
                {
                    Console.WriteLine("Hoşgeldiniz");
                }
                else
                {
                    Console.WriteLine("Yanlış Kullanıcı Adı");
                }
            } while (kullaniciAdi != "Admin" && sifre != "1234");


            Console.ReadKey();


        }
    }
}
