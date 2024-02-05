using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HashSet
{
    public class hashOperations
    {
        public static HashSet<string> NewHashSet = new HashSet<string>();
        public static void AddElementHashSet(string[] array)
        {
            foreach (string elements in array)
            {
                NewHashSet.Add(elements);
            }
        }

        public static void PrintHashSetElements()
        {
            Console.WriteLine("Printing Hash Set Elements");
            Thread.Sleep(1000);
            Console.Write("{ ");
            foreach (string element in NewHashSet)
            {
                Thread.Sleep(1000);
                Console.Write(element + " , ");
            }
            Thread.Sleep(1000);
            Console.WriteLine(" Null}");
            Console.WriteLine();
        }
        public static void RemoveElementHashSet(string[] RemoveElementsInArray)
        {
            foreach (string ArrayElement in RemoveElementsInArray)
            {
                NewHashSet.Remove(ArrayElement);
            }
            Console.Write("Removed These Elements { ");
            foreach (string Element in RemoveElementsInArray)
            {
                Thread.Sleep(1000);
                Console.Write(Element+", ");
            }
            Console.WriteLine(" Null };");
            Console.WriteLine("Printing Updated Array");
            PrintHashSetElements();
            Console.WriteLine();
        }
        public static void RemoveElementHashSet(string SingleElementToRemove)
        {
            Console.WriteLine("Removing " + SingleElementToRemove + " from the HashSet");
            NewHashSet.Remove(SingleElementToRemove);
            PrintHashSetElements();
            Console.WriteLine();
        }
    }
}
