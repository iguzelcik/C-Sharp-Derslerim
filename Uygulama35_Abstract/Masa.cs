using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_16122021_Abstract
{
    internal class Masa:Mobilya
    {
        public string malzeme;
        public override void ozellikyaz()
        {
            Console.WriteLine("Masanın Özellikleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("Malzeme: {0}", malzeme);
        }
    }
}
