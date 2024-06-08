using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6_161202021_Kolleksiyonlar_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                ArrayList arrayList = new ArrayList();
                arrayList.Add("Metin"); // string ekleniyor
                arrayList.Add(12); // int ekleniyor
                arrayList.Add(8f); // float ekleniyor
                arrayList.Add(new string[]
                    { "Ali", "Osman", "Hasan" }); // dizi ekleniyor
                Console.WriteLine(arrayList[0]);
                Console.WriteLine(arrayList[1]);
                Console.WriteLine(arrayList[2]);
                Console.WriteLine((arrayList[3] as string[])[0]);
                Console.WriteLine((arrayList[3] as string[])[1]);
                Console.WriteLine((arrayList[3] as string[])[2]);
                Console.ReadKey();
            
        }
    }
}
