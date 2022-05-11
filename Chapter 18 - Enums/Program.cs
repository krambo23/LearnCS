using System;

namespace EnumApplication
{
    class EnumProgram
    {
        enum Days
        {
            Sunday, 
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday
        };

        static void Main(string[] args)
        {
            int weekStart = (int) Days.Monday;
            int weekEnd = (int) Days.Friday;
            System.Console.WriteLine("Monday: {0}", weekStart);
            System.Console.WriteLine("Friday: {0}", weekEnd);
        }
    }
}