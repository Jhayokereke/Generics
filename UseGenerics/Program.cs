using System;
using Generics;

namespace UseGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Ola");
            stack.Push("Ramon");
            stack.Push("Ade");
            Console.WriteLine(stack.Size());
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Size());
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Size());
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(".........................");
            Console.WriteLine(stack.Size());
            stack.Push("Sam");
            Console.WriteLine(stack.Peek());
        }
    }
}
