// C# Doesn't Support Multiple Inheritance - Use Interfaces to Implement Multiple Interitance
using System;

namespace InheritanceApplication
{
    class Shape
    {
        protected int width;
        protected int height;

        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }
    }

    // Base Class 'PaintCost'
    public interface PaintCost
    {
        int GetCost(int area);
    }

    // Derived Class
    class Rectangle : Shape, PaintCost
    {
        public int GetArea()
        {
            return width * height;
        }

        public int GetCost(int area)
        {
            return area * 70;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            int area;
            rectangle.SetWidth(5);
            rectangle.SetHeight(7);
            area = rectangle.GetArea();

            System.Console.WriteLine($"Total Area: {area}");
            System.Console.WriteLine($"Total Paint Cost: ${rectangle.GetCost(area)}");
        }
    }
}
// pg 160 - 162