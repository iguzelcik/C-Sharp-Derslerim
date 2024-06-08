using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama7_15122021_Interface_Arayuz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IArabaSur Polo = new Araba();
            Polo.Calistir();
            Polo.VitesDegistir(2);
            Polo.Sur();
            Polo.Parket();
            Polo.Durdur();
            Console.ReadKey();
        }
    }
}
