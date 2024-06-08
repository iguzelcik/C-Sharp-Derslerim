using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3_14122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri yeniMusteri=new Musteri();
            Console.Write("Yeni Müşteri Adı:");
            yeniMusteri.Ad=Console.ReadLine();
            Console.Write("Yeni Müşteri Soyadı:");
            yeniMusteri.Soyad=Console.ReadLine();
            Console.Write("Yeni Müşteri KimlikNumarasi:");
            yeniMusteri.KimlikNumarasi=Console.ReadLine();
            Console.Write("Vize1 Puanı:");
            yeniMusteri.Vize1Puan =Console.ReadLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine(yeniMusteri.Ad);
            Console.WriteLine(yeniMusteri.Soyad);
            Console.WriteLine(yeniMusteri.KimlikNumarasi);
            Console.WriteLine(yeniMusteri.Vize1Puan);
            Console.ReadLine();
        }
    }
}
