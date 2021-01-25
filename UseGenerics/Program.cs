using System;
using Generics;

namespace UseGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            Console.WriteLine(queue.Count);
            queue.Enqueue("Damilola");
            Console.WriteLine(queue.Count);
            queue.Enqueue("Samuel");
            Console.WriteLine(queue.Count);
            queue.Enqueue("Bolu");
            Console.WriteLine(queue.Count);
            queue.Enqueue("Nnenna");
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
        }
    }
}
