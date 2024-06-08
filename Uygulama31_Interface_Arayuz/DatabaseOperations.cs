using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama10_15122021_Interface_Arayuz
{
    internal class DatabaseOperations:IDatabaseOperations
    {
        public void Add()
        {

            Console.WriteLine("Veritabanına ekleme yapıldı");
        }
        public void Delete(int id)
        {
            Console.WriteLine("Veritabanından {0} numaralı id silindi",id);
        }
        public void GetById(int id)
        {
            Console.WriteLine("Veritabanından {0} numaralı id getirildi", id);
        }
        public void Update(int id)
        {
            Console.WriteLine("Veritabanından {0} numaralı id güncellendi", id);
        }

    }
}
