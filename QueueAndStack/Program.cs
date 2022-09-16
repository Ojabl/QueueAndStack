using System;
using System.Collections.Generic;

namespace QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("First in line");
            myQueue.Enqueue("Second in line");
            myQueue.Enqueue("Third in line");
            myQueue.Enqueue("Fourth in line");

            Console.WriteLine($"Peek() returned:\n{myQueue.Peek()}");

            Console.WriteLine($"The first Dequeue() returned:\n{myQueue.Dequeue()}");
            Console.WriteLine($"The first Dequeue() returned:\n{myQueue.Dequeue()}");

            Console.WriteLine($"Count before Clear():\n{myQueue.Count()}");
            myQueue.Clear();
            Console.WriteLine($"Count after Clear():\n{myQueue.Count()}");
        }
    }
}