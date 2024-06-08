using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6_15122021_Interface_Arayuz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //her new ile oluşturduğumuz örnekte farklı adresler oluşturduğu için oluşturulan örnekler aynı olmaz
            IslemNo islem1 = new IslemNo("001", "12/15/2021", 78900.00);
            IslemNo islem2 = new IslemNo();
            IslemNo islem3 = new IslemNo("002", "12/11/2021", 451900.00);

            Iislemler islem4 = new IslemNo("003", "12/7/2021", 48952.00);
            Iislemler islem5 = new IslemNo();
            Iislemler islem6 = new IslemNo("004", "12/5/2021", 85264.00);

            IslemNo islem12 = new IslemNo();
            
            islem12 = (IslemNo) islem5;

            if (islem12 == islem5)
            {
                Console.WriteLine("eşit");
            }
            else
            {
                Console.WriteLine("eşit değil");
            }


            islem1.islemgoster();
            islem2.islemgoster();
            islem3.islemgoster();
            Console.WriteLine("-----------------------------------------");
            islem4.islemgoster();
            islem5.islemgoster();
            islem6.islemgoster();
            Console.ReadKey();
        }
    }
}
