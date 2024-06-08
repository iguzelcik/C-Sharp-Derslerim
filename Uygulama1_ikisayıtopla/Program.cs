using System;


namespace Uygulama1_13122021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc, say1, say2;
            Console.WriteLine("1.sayıyı giriniz");
            say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz");
            say2 = Convert.ToInt32(Console.ReadLine());
            
            sonuc = say1 + say2;
            Console.WriteLine("{0} + {1}={2}", Convert.ToString(say1), Convert.ToString(say2), Convert.ToString(sonuc));

            Console.ReadKey();
        }
    }
}
