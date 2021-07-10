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
            stack.Display();

            Console.WriteLine("*********************************************");
            Console.WriteLine(" Queue\n");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine(" Before Dequeue");
            queue.Display();
            queue.Dequeue();
            Console.WriteLine(" After Dequeue");
            queue.Display();

            Console.WriteLine("*********************************************");

        }
    }
}
