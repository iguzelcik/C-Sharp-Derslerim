using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama13_15122021_Virtual_Sanal_Method
{
    internal class Program
    {
        public class Sekil
        {
            public virtual double Alan() {
                return 0; 
            }
        }
        public class Daire : Sekil
        {
            private double yariCap;
            //public double YariCap { get { return yariCap; } set { yariCap = value; } }
            // this.yariCap -->private double yariCap;  yariCap--> methodun içindeki parametre --> public Daire(double yariCap)
            public Daire(double yariCap)
            {
                this.yariCap = yariCap;
            }
            public override double Alan()
            {
                return (Math.PI)*Math.Pow(yariCap, 2);
            }
        }

        public class Kare:Sekil
        {
            public double uzunluk;
            public Kare(double uzunluk)
            {
                this.uzunluk = uzunluk;
            }

            public override double Alan()
            {
                //return uzunluk*uzunluk;
                return Math.Pow(uzunluk, 2);
            }
        }

        static void Main(string[] args)
        {
            Sekil daire = new Daire(4);
            Console.WriteLine("DaireninAlanı: {0}",daire.Alan());
            Sekil kare = new Kare(7);
           
            Console.WriteLine("Karenin Alanı: {0}", kare.Alan());

            Console.ReadKey();
        }
    }
}
