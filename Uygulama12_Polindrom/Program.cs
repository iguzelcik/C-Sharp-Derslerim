using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama12_13122021
{
    internal class Program
    {
        //Kullanıcının girdiği ifadenin Polindrom olup olmadığını test eden
        static void Main(string[] args)
        {
            string kelime;
            int uzunluk;
            Console.Write("Kelime Giriniz: ");
            kelime=Console.ReadLine();
            char[] polindrom = new char[kelime.Length];
            for (int i = 0; i < kelime.Length; i++)
            {
                polindrom[i] = kelime[i];
                //Console.WriteLine(polindrom[i]);
            }
            uzunluk = kelime.Length ;
            Console.WriteLine("Uzunluk:{0}", uzunluk);
            int sayac = 0;
            for(int i = 0;i < kelime.Length; i++)
            {
                uzunluk--;
                //Console.Write("{0}", kelime[uzunluk]);
                //Console.WriteLine();
                //Console.Write("{0}",  polindrom[i]);
                if (kelime[uzunluk] != polindrom[i])
                {
                   sayac++;
                }
            }
            if (sayac > 0)
            {
                Console.WriteLine("Polindrom değil");

            }
            else
            {
                Console.WriteLine("Polindrom");
            }
            Console.ReadKey();
        }
    }
}
