using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama11_15122021_Interface_arayuz_cokluKalitim
{
    internal class Ogrenci : IKisiBilgileri
    {
        private string adSoyad, ePosta, telefon;
        private double dersNotu;

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
        public double Not
        {
            get { return this.dersNotu; }
            set { dersNotu = value; }
        }
    }
}
