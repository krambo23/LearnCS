using System;

namespace InheritanceApplication
{
    class Shape
    {
        protected int width;
        protected int height;
        
        public void setWidth(int width)
        {
            this.width = width;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }
    }

    // Derived Class
    class Rectangle: Shape
    {
        public int getArea()
        {
            return width * height;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.setWidth(5);
            rectangle.setHeight(7);
            System.Console.WriteLine($"Total Area: {rectangle.getArea()}");
        }
    }
}
// pg 156 - 158
