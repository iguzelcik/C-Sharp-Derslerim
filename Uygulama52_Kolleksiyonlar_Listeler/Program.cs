using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8_15122021_Kolleksiyonlar_Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İçerisinde tuttuğu veriler sabit türde verilerdir.
            //Add metodu ile veri ekleme, Remove ile silme, RemoveAt ile belli bir indisteki
            //veriyi silme, [] operatörü ile indisteki veriye doğrudan ulaşmak mümkündür.
            //Kullanımı oldukça basit bir koleksiyon türüdür.
            List<string> ulkeler = new List<string>();
            ulkeler.Add("Türkiye"); // Türkiye ülkesini ekle
            EkranaYaz(ulkeler);
            ulkeler.Add("Azerbaycan"); // Azerbaycan ülkesini ekle
            EkranaYaz(ulkeler);
            ulkeler.Add("Fransa"); // Fransa ülkesini ekle
            EkranaYaz(ulkeler);
            ulkeler.Add("Almanya"); // Almanya ülkesini ekle
            EkranaYaz(ulkeler);
            ulkeler.Add("Hollanda"); // Hollanda ülkesini ekle
            EkranaYaz(ulkeler);
            ulkeler.Add("İspanya"); // İspanya ülkesini ekle
            EkranaYaz(ulkeler);
            ulkeler.Add("Şili"); // Şili ülkesini ekle
            EkranaYaz(ulkeler);
            ulkeler.Remove("Almanya"); // Almanya ülkesini sil
            EkranaYaz(ulkeler);
            ulkeler.RemoveAt(4); // 4. indisteki ülkeyi sil
            EkranaYaz(ulkeler);
            ulkeler.Reverse(); // Tüm listeyi ters çevir
            EkranaYaz(ulkeler);
            ulkeler.AddRange(new string[5]
            {
        "Irak", "İran", "Pakistan", "Hindistan", "Çin"
            }); // Toplu halde diziyi ekler
            EkranaYaz(ulkeler);
            ulkeler.Insert(3, "Rusya"); // Rusya ülkesini 3. indisten ekler
            EkranaYaz(ulkeler);
            string[] yeni_ulkeler = new string[]
                { "Norveç", "İsveç", "Danimarka" };
            // yeni_ulkeler dizisini toplu halde 5. indisten ekler
            ulkeler.InsertRange(5, yeni_ulkeler);
            EkranaYaz(ulkeler);
            // Türkiye' nin listedeki indisini verir
            Console.WriteLine(ulkeler.IndexOf("Türkiye"));
            Console.ReadKey();
        }

        // parametresi string listesi türünden bir metot tanımla
        static void EkranaYaz(List<string> ulkeler)
        {
            Console.Clear(); // Her seferinde ekranı temizle
            foreach (var ulke in ulkeler)
                Console.WriteLine(ulke);
            Console.ReadKey();
        }
    }
}
