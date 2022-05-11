using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop
            int a = 10;
            while (a < 20) 
            {
                System.Console.WriteLine("While Loop");
                System.Console.WriteLine("Value of a = {0}", a);
                a++;
            }
            System.Console.WriteLine();

            // For Loop
            for (int i = 0; i < 20; i++)
            {
                System.Console.WriteLine("For Loop");
                System.Console.WriteLine("Value of i = {0}", i);
            }
            System.Console.WriteLine();

            // Do While Loop
            a = 10;
            do 
            {
                System.Console.WriteLine("Do While");
                System.Console.WriteLine("Value of a = {0}", a);
                a++;
            } while (a < 20);
            System.Console.WriteLine();

            // Control Statements - break
            a = 10;
            while (a < 20)
            {
                System.Console.WriteLine("Value of a = {0}", a);
                a++;
                if (a > 15) 
                {
                    // Terminate The Loop
                    break;
                }
            }
            System.Console.WriteLine();

            // Control Statements - continue
            a = 10;
            do
            {
                if (a == 15) 
                {
                    // Skip An Iteration
                    a++;
                    continue;
                }
                System.Console.WriteLine("Value of a = {0}", a);
                a++;
            } while (a < 20);
            System.Console.WriteLine();
        }
    }
}
// pg 68, 69
// pg 71, 72
// pg 73, 74
// pg 79, 80
// pg 81, 82