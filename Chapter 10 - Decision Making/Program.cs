using System;

namespace DecisionMaking
{
    class Program
    {
        static void IfStatements()
        {
            int a = 10;

            // 'a' is less than 20
            if (a < 20)
            {
                System.Console.WriteLine("a < 20");
            }
            else if (a > 20) 
            {
                System.Console.WriteLine("a > 20");
            }
            else
            {
                System.Console.WriteLine("a == 20");
            }
        }

        static void SwitchStatements()
        {
            char grade = 'A';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }

        static void Main(string[] args)
        {
            IfStatements();
            System.Console.WriteLine();
            SwitchStatements();
        }
    }
}
// pg 55
// pg 62