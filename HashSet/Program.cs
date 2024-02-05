using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {

        static void Main(string[] args)
        {
            hashOperations hashOperations = new hashOperations();
            string[] arrNames = { "Arun", "Garv", "Sunil" , "Roshan", "Prince" };
            string[] SampleArrayElements = { "Garv", "Roshan" };
            string RemoveSingleElement = "Sunil";
            hashOperations.AddElementHashSet(arrNames);
            hashOperations.PrintHashSetElements();
            hashOperations.RemoveElementHashSet(SampleArrayElements);
            hashOperations.RemoveElementHashSet(RemoveSingleElement);
            Console.ReadLine();
        }
    }
}
