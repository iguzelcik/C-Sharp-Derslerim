using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5_15122021_Kalıtım
{
    internal class Calisan
    {
        private int _calisanNo;
        private string _calisanAd;
        private double _calisanMaas;
        public int CalisanNo
        {
            get { return _calisanNo; }
            set { _calisanNo = value; }
        }
        public string CalisanAd
        {
            get { return _calisanAd; }
            set { _calisanAd = value; }
        }
        public double CalisanMaas
        {
            get { return _calisanMaas; }
            set { _calisanMaas = value; }
        }
    }
}
