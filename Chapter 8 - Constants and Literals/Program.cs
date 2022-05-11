using System;

namespace ConstantsAndLiterals
{
    class Program
    {
        static void EscapeCharacters()
        {
            System.Console.WriteLine("Hello\tWorld\n\n");
        }

        static void DeclaringConstants()
        {
            // Declaring Constant
            const double PI = 3.14159;

            double radius;

            System.Console.Write("Input Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            double areaOfCircle = PI * radius * radius;
            System.Console.WriteLine("Radius = {0}\nArea: {1}", radius, areaOfCircle);
        }

        static void Main(string[] args)
        {
            EscapeCharacters();

            DeclaringConstants();
        }
    }
}
// pg 30, 31