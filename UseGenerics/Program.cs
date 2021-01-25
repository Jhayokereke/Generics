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
            List.Add("Damilola");
            Console.WriteLine(List.Count);
            List.Add("Samuel");
            Console.WriteLine(List.Count);
            List.Add("Bolu");
            Console.WriteLine(List.Count);
            List.Add("Nnenna");
            Console.WriteLine(List.Count);
            List.Remove("Bolu");
            Console.WriteLine(List.Count);
            Console.WriteLine(List.Check("Nnenna"));
            Console.WriteLine(List.Count);
            List.Remove("Nnenna");
            Console.WriteLine(List.Count);
            Console.WriteLine(List.Check("Nnenna"));
            Console.WriteLine(List.Count);
        }
    }
}
