using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama7_15122021_Interface_Arayuz2
{
    internal class Araba:IArabaSur
    {
        public void Calistir()
        {
            Console.WriteLine("Araba Çalıştırıldı.. ");
        }
        public void Sur()
        {
            Console.WriteLine("Sürmeye Devam");
        }
        public void Parket()
        {
            Console.WriteLine("Park Etme İşlemi Yapılıyor");
        }
        public void VitesDegistir(int vites)
        {
            Console.WriteLine(vites.ToString() + " . vitese geçildi");
        }
    
        public void Durdur()
        {
            Console.WriteLine("Varış.");
        }
    }
}
