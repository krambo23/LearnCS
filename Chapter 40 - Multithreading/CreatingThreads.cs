using System;
using System.Threading;

namespace MultiThreadingApplication
{
    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            System.Console.WriteLine("Child Thread Starts!");

            // Pause Thread for 500ms
            int sleepFor = 5000;
            System.Console.WriteLine($"Child Thread Paused for {sleepFor / 1000}s");
            Thread.Sleep(sleepFor);

            System.Console.WriteLine("Child Thread Resumes!");
        }

        public static void StarterFunction(string[] args)
        {
            // Create Thread
            ThreadStart childRef = new ThreadStart(CallToChildThread);
            System.Console.WriteLine("In Main, Creating Child Thread");
            Thread childThread = new Thread(childRef);
            childThread.Start();
        }
    }
}
// pg 323, 324