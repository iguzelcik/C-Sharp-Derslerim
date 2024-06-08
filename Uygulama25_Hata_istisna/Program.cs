using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4_15122021_Hata_istisna
{
    internal class Program
    {
        static void Main(string[] args)
        {            
                Console.WriteLine("Sayı giriniz");
                try
                {
                int i = int.Parse(Console.ReadLine()); //Convert.toInt32
            }
            //catch (Exception ex)
            //{ Console.WriteLine(ex.Message); }
            catch (FormatException exp)
            {
                //Console.WriteLine("Girdiğiniz değerin biçimi sorunlu")
                Console.WriteLine(exp.Message);
            }
            catch (OverflowException exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                Console.WriteLine("finally bloğu çalışıyor...");
            }
            Console.ReadKey();
        }
    }
    
}
