using System;

namespace RectangleApplication
{
    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class TableTop : Rectangle
    {
        private double cost;

        public TableTop(double l, double w) : base(l, w)
        {

        }

        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            TableTop tableTop = new TableTop(4.5, 7.5);
            tableTop.Display();
        }
    }
}
// pg 158 - 160