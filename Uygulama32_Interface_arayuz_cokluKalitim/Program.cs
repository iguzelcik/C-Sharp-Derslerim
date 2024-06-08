using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama11_15122021_Interface_arayuz_cokluKalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKisiBilgileri ogretimGorevlisiKisi=new OgretimGorevlisi();
            ICalisanBilgileri ogretimGorevlisiCalisan = new OgretimGorevlisi();
            ogretimGorevlisiKisi.AdSoyad = "İlker Güzelcik";
            ogretimGorevlisiCalisan.Departman = "Matematik Bölümü";
           Console.WriteLine(ogretimGorevlisiKisi.AdSoyad);
            Console.WriteLine(ogretimGorevlisiCalisan.Departman);
            Console.ReadKey();

        }
    }
}
