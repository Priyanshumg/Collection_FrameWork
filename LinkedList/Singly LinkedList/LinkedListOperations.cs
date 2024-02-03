using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Doubly_LinkedList
{
    public static class LinkedListOperations
    {
        public static LinkedList<string> my_list = new LinkedList<string>();

        static LinkedListOperations()
        {
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");
        }

        public static void PrintLinkedList(LinkedList<string> mylist)
        {
            // Printing all elements in a linkedlist
            Console.Write("CurrentList { ");
            Thread.Sleep(1000);
            foreach (string str in mylist)
            {
                Console.Write("{0}, ", str);
                Thread.Sleep(500);
            }
            Console.WriteLine("Null }");
            Console.WriteLine();
        }

        public static void RemoveFirstElement(LinkedList<string> mylist)
        {
            my_list.RemoveFirst();
            Console.WriteLine("Removed First Element of a LinkedList");
            PrintLinkedList(my_list);
        }

        public static void RemoveLastElement(LinkedList<string> mylist)
        {
            mylist.RemoveLast();
            Console.WriteLine("Removed Last Element of a LinkedList");
            Console.WriteLine("Printing Current LinkedList of Elements:");
            PrintLinkedList(my_list);
        }

        public static void RemoveIndexByValue(string nodeValue)
        {
            Console.WriteLine("Removing the Index value provided {0}", nodeValue);
            Console.WriteLine("Printing Current LinkedList of Elements:");
            my_list.Remove(nodeValue);
            PrintLinkedList(my_list);
        }

        public static void RemoveFirstOccurence(LinkedList<string> mylist)
        {
            Console.WriteLine("Removing the Index value provided first Occurence");
            Console.WriteLine("Printing Current LinkedList of Elements:");
            mylist.RemoveFirst();
            PrintLinkedList(my_list);
        }

        public static void RemoveAllElementsLinkedList(LinkedList<string> mylist)
        {
            Console.WriteLine("Removing All Elements in a LinkedList");
            mylist.Clear();
            Console.WriteLine("Removed All Elements from LinkedList");
            PrintLinkedList(my_list);
        }
    }
}
