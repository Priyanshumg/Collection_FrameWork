using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        public static List<int> myList = new List<int>();

        static void Main(string[] args)
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            myList.Remove(4);
            myList.RemoveAt(3)
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
