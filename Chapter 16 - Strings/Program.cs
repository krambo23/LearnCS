using System;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Literals & String Concatenation
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";
            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            // String Constructor
            char[] letters = {'H', 'e', 'l', 'l','o'};
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            // Methods Returning a String
            string[] stringArray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", stringArray);
            Console.WriteLine("Message: {0}", message);

            // Convert DateTime to a String
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }
    }
}
// pg 124, 125