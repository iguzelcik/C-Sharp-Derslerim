using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8_15122021_Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futbolcu ronaldo = new Futbolcu();
            ronaldo.ÜLKE = "portekiz";
            ronaldo.LİG = "Serie A";
            ronaldo.TAKIM = "JUVENTUS";
            ronaldo.İSİM = "Cristiano"; // TOLOVER SAYESİNDE HEPSİNİ KÜÇÜK HARF YAZDI
            ronaldo.SOYİSİM = "Ronaldo";
            ronaldo.MEVKİ = "santrafor";
            ronaldo.YAŞI = -36; // YAŞ NEGATİF OLSADA POZİTİF Olacak

            Console.WriteLine("ÜLKE: " + ronaldo.ÜLKE);
            Console.WriteLine("LİĞ: " + ronaldo.LİG);
            Console.WriteLine("TAKIM: " + ronaldo.TAKIM);
            Console.WriteLine("İSİM: " + ronaldo.İSİM);
            Console.WriteLine("SOYİSİM: " + ronaldo.SOYİSİM);
            Console.WriteLine("MEVKİ: " + ronaldo.MEVKİ);
            Console.WriteLine("YAŞI: " + ronaldo.YAŞI);
            Console.ReadKey();
        }
    }
}
