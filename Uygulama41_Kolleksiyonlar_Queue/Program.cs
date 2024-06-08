using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama7_161202021_Kolleksiyonlar_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enqueue metodu ile içerisine nesne eklenir.
            //Dequeue metodu ile de eklenen nesneler metodun dönüş değeri olarak çıkarılır.
            //İlk eklenen nesne ilk olarak çıkarılır.
            //Ekleme ve çıkarma mantığı tamamen bir kuyruğun ilerleyişi gibidir.
            Queue queue = new Queue();
            queue.Enqueue("1. Nesne");
            queue.Enqueue("2. Nesne");
            queue.Enqueue("3. Nesne");
            Console.WriteLine("Kuyrukta " + queue.Count + " adet nesne var");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Kuyrukta " + queue.Count + " adet nesne var");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.ReadKey();
        }
    }
}
