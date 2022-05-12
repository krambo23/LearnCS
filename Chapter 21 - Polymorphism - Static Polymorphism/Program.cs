using System;
namespace PolymorphismApplication
{
    class PrintData
    {
        void Print(int i)
        {
            Console.WriteLine("Printing int: {0}", i );
        }

        void Print(double f)
        {
            Console.WriteLine("Printing float: {0}" , f);
        }

        void Print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }

        static void Main(string[] args)
        {
            PrintData p = new PrintData();

            // Call Print to print integer
            p.Print(5);

            // Call Print to print float
            p.Print(500.263);

            // Call Print to print string
            p.Print("Hello C#");
        }
    }
}
// pg 163, 164