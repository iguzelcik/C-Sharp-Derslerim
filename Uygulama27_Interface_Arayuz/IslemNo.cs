using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6_15122021_Interface_Arayuz
{
    internal class IslemNo:Iislemler
    {
        private string islemkodu;
        private string Tarih;
        private double Tutar;
        public IslemNo() //Constructors Yapıcı Method
        {
            islemkodu = " ";
            Tarih = " ";
            Tutar = 0.0;
        }     
        public IslemNo(string c, string d, double a)
        {
            islemkodu = c;
            Tarih = d;
            Tutar = a;
        }     
        public double tutargetir()
        {
            return Tutar;
        }
        public void islemgoster()
        {
            Console.WriteLine("İşlem No: {0}", islemkodu);
            Console.WriteLine("Tarih: {0}", Tarih);
            Console.WriteLine("Tutar: {0}", tutargetir());
        }
    }
}
