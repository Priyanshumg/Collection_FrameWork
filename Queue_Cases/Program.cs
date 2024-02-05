using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue myq = new Queue();
            myq.Enqueue("a");
            myq.Enqueue("b");
            myq.Enqueue("c");
            foreach(object item in myq)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
