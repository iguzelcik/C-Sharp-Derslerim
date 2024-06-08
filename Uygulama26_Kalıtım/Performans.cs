using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5_15122021_Kalıtım
{
    internal class Performans:Calisan
    {
        private int performansPuani;
        private int performansZammi;
        public int PerformansPuan
        {
            get { return performansPuani; }
            set { performansPuani = value; }
        }
        

        public int PerformansZam
        {
            get { return performansZammi; }
            set { performansZammi = value; }
        }
    }
}
