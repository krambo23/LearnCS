using System;

namespace TypeConversionApplication
{
    class TypeConversion
    {
        static void ExplicitConversion()
        {
            // region Explicit Conversion
            double d = 5673.74;
            int i;

            // Cast 'double' to 'int'
            i = (int) d;
            Console.WriteLine(i);
        }

        static void StringConversion()
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
        }

        static void Main(string[] args)
        {
            ExplicitConversion();
            StringConversion();
            
            Console.ReadKey();
        }
    }
}
// pg 21, 23