using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2_14122021
{
    internal class Personel
    {
        public static int PersonelSayısı;
        private static int say=15;
        private string isim;
        // Okuma ve Yazma Özelliği
        public string Isım
        {
            get { return isim; }
            set { isim = value; }
        }

        // Sadece Okunabilir Özelliği
        public static int Say
        {
            get { return say; }
        }

        // Yapıcı metodumuz. class ta ilk önce otomatik olarak çalışır
        public Personel()
        {
            // Personel Sayısını Hesapla
            say = ++PersonelSayısı;
            
        }
        //yıkıcı metot çalıştı
        ~Personel()
        {
            Console.WriteLine("yıkıcı metot çalıştırıldı");
        }

    }
}
