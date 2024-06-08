using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3_13122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iki vize ve bir final puanı girilecek. vizelerin %30 yu finalin %40 alınarak Puan hesaplanacak
            // Puan 0-44 -->F
            // Puan 45-54 -->D
            // Puan 55-69 -->C
            // Puan 70-85 -->B
            // Puan 85 +  -->A

            double vize1, vize2, final, puan;
            Console.WriteLine("1. Vize Puanı Giriniz:");
            vize1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Vize Puanı Giriniz:");
            vize2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final Puanı Giriniz:");
            final = Convert.ToDouble(Console.ReadLine());

            //Puan hesaplayacağız
            puan = vize1 * 0.3 + vize2 * 0.3 + final * 0.4;

            Console.WriteLine("Puan: {0}",puan);
           

            if (puan < 45)
            {
                Console.WriteLine("F");
            }else if (puan < 55)
            {
                Console.WriteLine("D");
            }else if (puan < 70)
            {
                Console.WriteLine("C");
            }
            else if (puan < 85)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }

            Console.ReadLine();
        }
    }
}
