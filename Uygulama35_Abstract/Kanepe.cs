using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_16122021_Abstract
{
    internal class Kanepe:Mobilya
    {
        public string kumas;
        public override void ozellikyaz()
        {
            Console.WriteLine("Kanepenin Özellikleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("Kumaş: {0}", kumas);
        }
    }
}
