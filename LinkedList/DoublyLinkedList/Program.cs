using System;
using System.Threading;

namespace Doubly_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding Elements to the LinkedList");
            Thread.Sleep(3000);
            Console.WriteLine("Added SuccessFully");
            Thread.Sleep(2000);

            // Adding elements to a linkedlist
            LinkedListOperations.PrintLinkedList(LinkedListOperations.my_list);

            // Remove First Element in LinkedList --> removes Zoya
            LinkedListOperations.RemoveFirstElement(LinkedListOperations.my_list);

            // Removes Last Element in a LinkedList
            LinkedListOperations.RemoveLastElement(LinkedListOperations.my_list);

            // Remove node by the value
            LinkedListOperations.RemoveIndexByValue("Rohan");

            // Removing First Occurence in a LinkedList
            LinkedListOperations.RemoveFirstOccurence(LinkedListOperations.my_list);

            // Removing all the elements in LinkedList
            LinkedListOperations.RemoveAllElementsLinkedList(LinkedListOperations.my_list);

            Console.Read();
        }
    }
}
