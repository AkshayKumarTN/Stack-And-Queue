using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Stack
    {

        internal Node top;
        public Stack()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.Next = top;
                top = node;
            }
        }
        public void Display()
        {
            Node temp = top;
            if (top == null)
                Console.WriteLine(" Stack is Empty");
            else
            {
                Console.Write(" " + temp.data);
                temp = temp.Next;
                while (temp != null)
                {
                    Console.Write(" -> " + temp.data);
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
