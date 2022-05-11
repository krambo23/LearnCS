using System;

namespace RectangleApplication
{
    class Rectangle
    {
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            System.Console.WriteLine("Length = {0}", length);
            System.Console.WriteLine("Width = {0}", width);
            System.Console.WriteLine("Area = {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.length = 4.5;
            rectangle.width = 3.5;
            rectangle.Display();
        }
    }
}
// pg 84, 85