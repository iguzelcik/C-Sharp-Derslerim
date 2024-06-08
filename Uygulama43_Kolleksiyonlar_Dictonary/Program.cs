using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9_15122021_Kolleksiyonlar_Dictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // anahtar türü string değer türü string dizisi olan bir sözlük tanımlanır
            Dictionary<string, string[]> departmanlar = new Dictionary<string, string[]>();
            string[] muhasebe_personeli = new string[]
                { "Ahmet", "Mehmet", "Işıl" };
            departmanlar.Add("Muhasebe", muhasebe_personeli);
            departmanlar.Add("Tasarım", new string[] {
        "Emre", "Kaan", "Songül", "Gülcan"
    }); // Add metoduyla sözlüğe anahtar ve değer eklenebilir
            departmanlar["Bilişim"] = new string[2]
            {
        "Yusuf", "Tarık"
            }; // atama suretiyle sözlüğe anahtar ve değer eklenebilir
            while (true)
            {
                Console.Write("Departman: ");
                string anahtar = Console.ReadLine();
                if (departmanlar.ContainsKey(anahtar))
                    EkranaYaz(departmanlar[anahtar]);
                else
                    Console.WriteLine("Departman bulunamadı");
            }
        }

        static void EkranaYaz(string[] kisiler)
        {
            Console.Clear(); // Her seferinde ekranı temizle
            foreach (var kisi in kisiler)
                Console.WriteLine(kisi);
            Console.ReadKey();
        }
    }
}
