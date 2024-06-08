using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5_15122021_Kalıtım
{
    internal class Yonetici:Calisan
    {
        private double _departmanKar;

        public double DepartmanKar
        {
            get { return _departmanKar; }
            set { _departmanKar = value; }
        }
    }
}
