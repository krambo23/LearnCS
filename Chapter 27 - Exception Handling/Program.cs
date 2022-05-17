using System;

namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        int result;

        DivNumbers()
        {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine($"Exception Caught : {e}");
            }
            finally
            {
                System.Console.WriteLine($"Result : {result}");
            }
        }

        public static void Main(string[] args)
        {
            DivNumbers d1 = new DivNumbers();
            d1.division(20, 5);

            System.Console.WriteLine();
            
            DivNumbers d2 = new DivNumbers();
            d2.division(10, 0);
        }
    }
}
// pg 210, 211