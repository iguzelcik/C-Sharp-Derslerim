using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3_16122021_Struct
{
    internal class Program
    {
        struct Urun
        {
            public int urunNo;
            public string urunAdi;
            public string urunKategori;
            public string urunAciklama;

            
            
            public Urun(int a, string b, string c, string d)
            {
                urunNo = a;
                urunAdi = b;
                urunKategori = c;
                urunAciklama = d;
            }
        }
     
        static void Main(string[] args)
        {
            Urun yeniurun = new Urun(15, "Tablet Pc", "Elektronik", "Ev Kullanımı İçin Uygun");
            
            
            Console.WriteLine(yeniurun.urunNo);
            Console.WriteLine(yeniurun.urunAdi);
            Console.WriteLine(yeniurun.urunKategori);
            Console.WriteLine(yeniurun.urunAciklama);


            Console.ReadKey();
        }
    }
}
