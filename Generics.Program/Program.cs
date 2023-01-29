using System;

namespace Generics.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            linkedList.Remove(5);
            linkedList.Remove(3);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
