using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8_15122021_Kalıtım
{
    internal class Sporcu
    {
        private string isim;
        private string soyisim;
        private int yaş;
        private string mevki;

        public string İSİM
        {
            get { return isim; }
            set { isim = value.ToLower(); } //ToLower Küçük harfe çevirir
        }
        public string SOYİSİM
        {
            get { return soyisim; }
            set { soyisim = value.ToUpper(); } //Toupper Büyük harfe çevirir
        }
        public int YAŞI
        {
            get { return yaş; }
            set { yaş = Math.Abs(value); } // negatifi pozitif yapar
        }
        public string MEVKİ
        {
            get { return mevki; }
            set { mevki = value.ToUpper(); }
        }
    }
}
