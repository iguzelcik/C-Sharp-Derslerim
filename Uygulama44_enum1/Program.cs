using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama10_16122021_enum
{
    internal class Program
    {
        enum Importance
        {
            None,
            Trivial,
            Regular,
            Important,
            Critical
        }

        static void Main()
        {
            // Step 1: create an enum local.
            Importance value =  Importance.Critical;
            int value2 = (int)Importance.Critical;
            // Step 2: test against a known Importance value.
            Console.WriteLine("value2={0}", value2);
            if (value == Importance.Critical)
            {
                Console.WriteLine(true);
            }
            Console.ReadKey();
        }
    }
}
