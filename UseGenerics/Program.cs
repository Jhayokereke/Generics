using System;
using Generics;

namespace UseGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> List = new LinkedList<string>();
            Console.WriteLine(List.Count);
            List.Add("Paul");
            List.Add("Dammy");
            Console.WriteLine(List.Count);
            List.Remove("Paul");
            Console.WriteLine(List.Check("Paul"));
            Console.WriteLine(List.Count);
            List.Add("Daniel");
            List.Add("Bola");
            List.Add("Toyo");
            List.Add("Sam");
            Console.WriteLine(List.Index("Sam"));
            Console.WriteLine(List.Count);

            List.Remove("Bola");
            Console.WriteLine(List.Index("Bola"));
            Console.WriteLine(List.Add("John"));
        }
    }
}
