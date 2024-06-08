using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9_15122021_VirtualMethod_SanalMetotlar
{
    class IkinciElAraba:Araba
    {
        public override decimal Fiyat()
          {
        return fiyati - 100;
          }
}
}
