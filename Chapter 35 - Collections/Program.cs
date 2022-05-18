using System;
using System.Collections;
namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Adding some numbers...");

            arrayList.Add(45);
            arrayList.Add(78);
            arrayList.Add(33);
            arrayList.Add(56);
            arrayList.Add(12);
            arrayList.Add(23);
            arrayList.Add(9);

            Console.WriteLine("Capacity: {0} ", arrayList.Capacity);
            Console.WriteLine("Count: {0}", arrayList.Count);

            Console.Write("Content: ");
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Sorted Content: ");
            arrayList.Sort();
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}