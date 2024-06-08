using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4_131220221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int dogumAyi, dogumGunu;
            //Doğum günü ve Doğum ayına bakarak burç hesaplama
            Console.WriteLine("Doğduğunuz Gününüzü Giriniz");
            dogumGunu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doğduğunuz Ayınızı Giriniz");
            dogumAyi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doğduğunuz Ay: {0}", dogumAyi);

            switch (dogumAyi)
            {
                case 1:
                    if (dogumGunu < 21)
                    {
                        Console.WriteLine("Oğlak");
                    }
                    else
                    {
                        Console.WriteLine("Kova");
                    }
                    
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Girilen sayıya karşılık gelen bir ay yok");
                    break;
            }

 

            Console.ReadLine();
        }
    }
}
