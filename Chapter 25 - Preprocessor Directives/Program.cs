#define PI

using System;

namespace PreprocessorDirectivesApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            #if (PI)
                System.Console.WriteLine("PI is Defined!");
            #else
                System.Console.WriteLine("PI is Not Defined!");
            #endif
        }
    }    
}
// pg 191