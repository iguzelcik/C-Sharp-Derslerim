using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama10_15122021_Interface_Arayuz
{
    internal interface IDatabaseOperations
    {
        void Add();
        void Delete(int id);

        void GetById(int id);

        void Update(int id);

        
    }
}
