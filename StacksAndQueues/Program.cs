using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine(" Stack\n");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Peek();
            stack.Pop();
            stack.Peek();
            stack.Pop();
            stack.Peek();

            Console.WriteLine("*********************************************");
            Console.WriteLine(" Queue\n");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console.WriteLine("*********************************************");

        }
    }
}
