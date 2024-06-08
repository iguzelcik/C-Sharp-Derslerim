using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama11_16122021_enum
{
   
    internal class Program
    {
        enum Aylar : Byte
        {
            Ocak = 3, Şubat = 6, Mart = 15, Nisan = 45, Mayıs = 76, Haziran
        }
        static void Main(string[] args)
        {
             
        byte a = (byte) Aylar.Ocak; //cast
            byte b = (byte) Aylar.Şubat;
            byte c = (byte) Aylar.Mart;
            byte d = (byte) Aylar.Nisan;
            byte e = (byte) Aylar.Haziran;

            Console.WriteLine("Ocak={0}", (byte) Aylar.Ocak);
            Console.WriteLine("Şubat={0}", (byte) Aylar.Şubat);
            Console.WriteLine("Mart={0}", (byte) Aylar.Mart);
            Console.WriteLine("Nisan={0}", (byte) Aylar.Nisan);
            Console.WriteLine("Haziran={0}", (byte) Aylar.Nisan);

            Console.WriteLine("Ocak={0}", a);
            Console.WriteLine("Şubat={0}", b);
            Console.WriteLine("Mart={0}", c);
            Console.WriteLine("Nisan={0}", d);
            Console.WriteLine("Haziran={0}", e);
            Console.ReadKey();
        }
    }
}
