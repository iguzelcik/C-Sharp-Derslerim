using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2_14122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel.PersonelSayısı = 100;
            
            //New sözcüğü ile nesnenin örneği oluşturuldu
            Personel prsnl = new Personel();
            prsnl.Isım = "İlker Güzelcik";
            //nesne.özellik=değer;

            Console.WriteLine("Personel Sayısı: {0}", Personel.PersonelSayısı);
            //Çıktı: 101
          
            Console.WriteLine("Personel Ismi: {0}", prsnl.Isım);
            //Çıktı: İlker Güzelcik
            Console.WriteLine("test");
            Console.WriteLine("test2");
            Console.ReadKey();
        }
    }
}
