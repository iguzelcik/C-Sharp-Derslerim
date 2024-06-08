using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9_15122021_VirtualMethod_SanalMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba(); 
            
            IkinciElAraba ikinciElAraba = new IkinciElAraba();
            Console.WriteLine("Araba : " + araba.Fiyat());    
            //Sonuç 700'dür
            Console.WriteLine("İkinci El Araba : " + ikinciElAraba.Fiyat());
            //Sonuç 400'dür
            Console.ReadKey();
        }
    }
}
