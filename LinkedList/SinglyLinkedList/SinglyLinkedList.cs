using System;

namespace SinglyLinkedList
{
    internal class Node
    {
        internal string data; // Changed data type to string
        internal Node next;
        public Node(string d) // Changed parameter type to string
        {
            data = d;
            next = null;
        }
    }

    internal class SingleLinkedList
    {
        internal Node head;

        internal void InsertFront(SingleLinkedList singlyList, string new_data) // Changed parameter type to string
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }

        internal void InsertLast(SingleLinkedList singlyList, string new_data) // Changed parameter type to string
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void InsertAfter(Node prev_node, string new_data) // Changed parameter type to string
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        internal void DeleteNodebyKey(SingleLinkedList singlyList, string key) // Changed parameter type to string
        {
            Node temp = singlyList.head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
    }
}
internal class SingleLinkedList
{
    // Other methods...

    static void PrintLinkedList(SingleLinkedList singlyList)
    {
        Node currentNode = singlyList.head;
        Console.Write("Linked List: ");
        while (currentNode != null)
        {
            Console.Write(currentNode.data + " -> ");
            currentNode = currentNode.next;
        }
        Console.WriteLine("null");
    }
}
