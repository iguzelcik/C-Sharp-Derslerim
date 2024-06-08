using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama8_15122021_Kalıtım
{
    internal class Futbolcu:Sporcu
    {
        private string ülke;
        private string takım;
        private string lig;

        public string ÜLKE
        {
            get { return ülke; }
            set { ülke = value.ToUpper(); }
        }
        public string TAKIM
        {
            get { return takım; }
            set { takım = value.ToUpper(); }
        }
        public string LİG
        {
            get { return lig; }
            set { lig = value.ToUpper(); }
        }
    }
}
