using System;

namespace PolymorphismApplication
{
    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }

        // Implementing Method To Calculate Area
        public override int area()
        {
            return width * length;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 7);
            double area = rectangle.area();

            System.Console.WriteLine($"Area: {area}");
        }
    }
}
// pg 165, 166