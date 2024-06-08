using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2_16122021_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Liverpool liv = new Liverpool();
            Juventus juve = new Juventus();
            Console.WriteLine(liv.OnAd() + liv.Ad());
            Console.WriteLine(liv.KurulusYili());
            Console.WriteLine(juve.OnAd() + juve.Ad());
            Console.WriteLine(juve.KurulusYili());

            Console.ReadKey();
        }
        abstract class SporKulubu
        {   
            public abstract string Ad();
            public abstract int KurulusYili();
            public virtual string OnAd()
            {
                return "FC ";
            }
         }

        class Liverpool : SporKulubu
        {
            public override string Ad()
            {
                return "Liverpool";
            }
            public override int KurulusYili()
            {
                return 1892;
            }
           
        }

        class Juventus : SporKulubu
        {
            public override string Ad()
            {
                return "Juventus";
            }
            public override int KurulusYili()
            {
                return 1897;
            }
            public override string OnAd()
            {
                return "";
            }
        }
    }
}
