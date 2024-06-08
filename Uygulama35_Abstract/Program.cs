using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_16122021_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kanepe kanepe = new Kanepe();
            Masa calisma_masasi = new Masa();
            kanepe.renk = "Siyah";
            kanepe.kumas = "Deri";
            calisma_masasi.renk = "Sarı";
            calisma_masasi.malzeme = "Ahşap";
            kanepe.ozellikyaz();
            calisma_masasi.ozellikyaz();
            Console.ReadKey();
        }
    }
}
