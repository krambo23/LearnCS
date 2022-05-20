using System;
using System.Threading;

namespace MultiThreadingApplication
{
    class MainThreadProgram
    {
        public static void Main(string[] args)
        {
            // Name the Current Thread
            Thread thread = Thread.CurrentThread;
            thread.Name = "MainThread";
            System.Console.WriteLine($"This is {thread.Name}");

            // Creating and Managing Threads
            MultiThreadingApplication.ThreadCreationProgram.StarterFunction(args);

            // Destroy Threads
            MultiThreadingApplication.ThreadDesctructionProgram.StarterFunction(args);
        }
    }
}
// pg 319