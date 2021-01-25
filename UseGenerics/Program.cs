using System;
using Generics;

namespace UseGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            Stack<string> myStack = new Stack<string>();
            Console.WriteLine(myQueue.IsEmpty());
            myQueue.Enqueue("Bola");
            myQueue.Enqueue("Mary");
            myQueue.Enqueue("Reiner");
            myQueue.Enqueue("Eren");
            Console.WriteLine(myQueue.Size());
            myQueue.Enqueue("Queen");
            myQueue.Enqueue("Frank");
            myQueue.Enqueue("Jide");
            myQueue.Enqueue("Livinus");
            myQueue.Dequeue();
            Console.WriteLine(myQueue.IsEmpty());
            Console.WriteLine(myQueue.Size());

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
                Console.WriteLine("......................................");
            }
            Console.WriteLine(myStack.IsEmpty());
            Console.WriteLine(myStack.Size());
            myStack.Push("Bola");
            myStack.Push("Mary");
            myStack.Push("Reiner");
            myStack.Push("Eren");
            Console.WriteLine(myStack.Size());
            myStack.Push("Queen");
            myStack.Push("Frank");
            Console.WriteLine(myStack.Size());
            myStack.Push("Jide");
            myStack.Push("Livinus");
            Console.WriteLine(myStack.IsEmpty());
            myStack.Pop();
            Console.WriteLine("==================================");
            Console.WriteLine(myStack.Peek());
            Console.WriteLine("==================================");

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
