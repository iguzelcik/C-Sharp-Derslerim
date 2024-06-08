using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama11_15122021_Interface_arayuz_cokluKalitim
{
    internal class OgretimGorevlisi:ICalisanBilgileri,IKisiBilgileri
    {
        private string adSoyad, ePosta, telefon, departman, gorev, unvan;
        public string Departman
        {
            get { return departman; }
            set { departman = value; }
        }
        public string Gorev
        {
            get { return gorev; }
            set { gorev = value; }
        }
        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }
        public string EPosta
        {
            get { return this.ePosta; }
            set { ePosta = value; }
        }
        public string Telefon
        {
            get { return this.telefon; }
            set { telefon = value; }
        }
        public string Unvan
        {
            get { return this.unvan; }
            set { unvan = value; }
        }
    }
}
