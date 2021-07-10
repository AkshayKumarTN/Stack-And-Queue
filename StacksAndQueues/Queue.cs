using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Queue
    {
        internal Node head;
        public Queue()
        {
            this.head = null;
        }
        public void Enqueue(int data)
        {
            // Adding At Last in the Queue....
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = node;
            }
        }
        public void Dequeue()
        {
            // Delete At First in the Queue....
            if (head == null)
                Console.WriteLine(" Queue is Empty ");
            else
                head = head.Next;

        }
        public void Display()
        {
            // Displaying Queue....
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Console.Write("  ");
                while (temp != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.Next;
                }
                Console.Write("Null\n");
            }
        }
    }
}
