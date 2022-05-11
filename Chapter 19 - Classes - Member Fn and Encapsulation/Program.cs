using System;

namespace BoxApplication
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public void setLength(double length)
        {
            this.length = length;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getVolume()
        {
            return this.length * this.width * this.height;
        }
    }

    class BoxTester
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            double volume;

            box1.setLength(6.0);
            box1.setWidth(7.0);
            box1.setHeight(5.0);

            box2.setLength(12.0);
            box2.setWidth(13.0);
            box2.setHeight(10.0);

            volume = box1.getVolume();
            System.Console.WriteLine($"Box 1's Volume: {volume}");

            volume = box2.getVolume();
            System.Console.WriteLine($"Box 2's Volume: {volume}");
        }
    }
}
// pg 146 - 148