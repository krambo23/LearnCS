using System;

namespace LineApplication
{
    class Line
    {
        private double length;

        // Default Constructor
        public Line()
        {
            System.Console.WriteLine("Object is Created!");
        }

        // Parameterized Constructor
        public Line(double length)
        {
            System.Console.WriteLine("Object is Created!");
            this.length = length;
        }

        // Destructor
        ~Line()
        {
            System.Console.WriteLine("Object is Destroyed!");
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public double getLength()
        {
            return this.length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();
            line.setLength(6.0);
            System.Console.WriteLine($"Length of Line : {line.getLength()}");

            System.Console.WriteLine();

            line = new Line(10.0);
            System.Console.WriteLine($"Length of Line : {line.getLength()}");
        }
    }

}
// pg 148, 149
// pg 149, 150
// pg 151, 152