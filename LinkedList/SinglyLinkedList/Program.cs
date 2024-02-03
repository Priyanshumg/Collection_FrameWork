using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList linkedList1 = new SingleLinkedList();
            linkedList1.InsertFront(linkedList1,"Roshan");
            linkedList1.InsertFront(linkedList1,"Rohan");
            linkedList1.InsertFront(linkedList1,"Rahul");


        }
    }
}
