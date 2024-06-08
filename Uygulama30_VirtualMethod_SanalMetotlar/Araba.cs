using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9_15122021_VirtualMethod_SanalMetotlar
{
    class Araba
    {
        public decimal fiyati = 500;
        public virtual decimal Fiyat()
            {
        return fiyati + 200;
            }

}
}
