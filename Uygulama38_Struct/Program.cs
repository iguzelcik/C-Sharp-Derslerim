using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4_16122021
{
    internal class Program
    {
        struct Dikdortgen
        {
            int Genislik, Yukseklik;
            public Dikdortgen(int genislik, int yukseklik)
            {
                Genislik = genislik;
                Yukseklik = yukseklik;
            }
            public void AlanHesapla()
            {
                int alan = Genislik * Yukseklik;
                Console.WriteLine("Dikdörtgenin Alanı: {0}", alan);
            }
        }
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(100,25);
            dikdortgen.AlanHesapla();
            Console.ReadKey();
        }
    }
}
