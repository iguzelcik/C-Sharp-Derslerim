using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5_15122021_Kalıtım
{
    internal class Personel:Calisan
    {
        private int _satisSayisi;
        
        public int SatisSayisi
        {
            get { return _satisSayisi; }
            set { _satisSayisi = value; }
        }
        //Kurucu, Yapıcı metotlar Constructors
        public Personel()
        {

        }
    }
}
