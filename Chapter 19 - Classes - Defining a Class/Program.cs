using System;

namespace BoxApplication
{
    class Box
    {
        public double length;
        public double width;
        public double height;
    }

    class BoxTester
    {
        static void Main(string[] args)
        {
            // Initialise Classes
            Box box1 = new Box();
            Box box2 = new Box();
            double volume = 0.0;

            // Set Values
            box1.height = 5.0;
            box1.length = 6.0;
            box1.width = 7.0;

            box2.height = 10.0;
            box2.length = 12.0;
            box2.width = 13.0;

            // Calculate Volume
            volume = box1.height * box1.width * box1.length;
            Console.WriteLine("Volume of Box 1 : {0}", volume);

            volume = box2.height * box2.width * box2.length;
            Console.WriteLine("Volume of Box 2 : {0}", volume);
        }
    }
}
// pg 144, 145