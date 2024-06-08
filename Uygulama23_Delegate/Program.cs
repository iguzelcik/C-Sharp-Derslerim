using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2_15122021_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegeMesaj mesaj = new DelegeMesaj(MesajGoster);
            DelegeToplama toplama=new DelegeToplama(ToplamaIslemi);
            mesaj.Invoke();
            Console.Write("Toplam: {0}", toplama(3, 7));
            Console.ReadKey();
        }
        public delegate void DelegeMesaj();
        delegate int DelegeToplama(int x, int y);
        static int ToplamaIslemi(int x, int y)
        {
            return (x + y);
        }

        static void MesajGoster()
        {
            Console.WriteLine("Bu ilk delege örneğimiz");
        }


    }
}
