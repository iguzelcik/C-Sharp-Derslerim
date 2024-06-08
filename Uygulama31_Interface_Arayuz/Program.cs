using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama10_15122021_Interface_Arayuz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDatabaseOperations operations = new DatabaseOperations();
            operations.Add();
            operations.GetById(1);
            operations.Delete(1);
            operations.Update(1);
            Console.ReadKey();

        }
    }
}
