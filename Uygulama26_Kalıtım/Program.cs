using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5_15122021_Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yeni bir Yonetici elemanı oluşturuyoruz.
            Yonetici yonetici = new Yonetici();
            //Inheritance ile Calısan sınıfından aldığımız üyeler.
            yonetici.CalisanNo = 1;
            yonetici.CalisanAd = "İlker Güzelcik";
            yonetici.CalisanMaas = 8500.78;

            //Yöneyici sınıfında tanımlanan üyeler.
            yonetici.DepartmanKar = 175000;

            //Yeni bir Personel elamanı oluşturuyoruz ve üyelerini çağrıyoruz.
            //new sözcüğü class'ın örneğini yaratıyor
            Personel personel = new Personel();
            personel.CalisanNo = 2;
            personel.CalisanAd = "Beyazıt Alkan";
            personel.CalisanMaas = 4500.32;
            personel.SatisSayisi = 153;

            Console.WriteLine("Yönetici No: {0} Adı: {1} Maaşı: {2}, Departman Karı: {3}", yonetici.CalisanNo.ToString(), yonetici.CalisanAd.ToString(), yonetici.CalisanMaas.ToString(), yonetici.DepartmanKar.ToString());
            Console.WriteLine("Personel No: {0} Adı: {1} Maaşı: {2}, Satış Sayısı: {3}", personel.CalisanNo.ToString(), personel.CalisanAd.ToString(), personel.CalisanMaas.ToString(), personel.SatisSayisi.ToString());
            Console.Read();
        }
    }
}
