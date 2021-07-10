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
        public void Peek()
        {
            if (this.top == null)
                    Console.WriteLine("\n Stack is empty");
            else
                Console.WriteLine("\n "+top.data + " is in the top of the stack ", this.top.data);
           
        }

        public void Pop()
        {
            if (top == null)
                Console.WriteLine(" Stack is empty ");
            else
            {
                Console.WriteLine(" Popped Value from the Stack is " + top.data);
                top = top.Next;
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
