using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else {
                result = num2;
            }
            return result;
        }

        // Arguments Are Passed By Value
        public void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        // Arguments Are Passed By Reference
        public void swap_2(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        // Arguments Are Passed By Output
        public void GetValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;

            NumberManipulator n = new NumberManipulator();

            // Call Method
            ret = n.FindMax(a, b);
            System.Console.WriteLine("Max Value = {0}", ret);
            System.Console.WriteLine();

            // Call Method - Arguments Passed By Value
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
            n.swap(a, b);
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            System.Console.WriteLine();

            // Call Method - Arguments Passed By Reference
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
            n.swap_2(ref a, ref b);
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            System.Console.WriteLine();

            // Call Method - Arguments Passed By Output
            a = 100;
            Console.WriteLine("Before method call, value of a : {0}", a);
            n.GetValue(out a);
            Console.WriteLine("After method call, value of a : {0}", a);
        }
    }
}
// pg 92, 93
// pg 97, 98
// pg 99, 100
// pg 100, 101