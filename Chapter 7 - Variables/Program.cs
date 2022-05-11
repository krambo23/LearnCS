using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Definition
            short a;
            int b;
            double c;


            // Actual Initialisation
            a = 10;
            b = 20;
            c = a + b;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            // Accepting User Input
            int num;
            System.Console.Write("Input An Integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User Input = {0}", num);

            Console.ReadLine();
        }
    }
}