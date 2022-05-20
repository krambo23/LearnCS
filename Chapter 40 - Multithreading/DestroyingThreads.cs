using System;
using System.Threading;

// Check https://youtu.be/TKc5A3exKBQ for more details
namespace MultiThreadingApplication
{
    class ThreadDesctructionProgram
    {
        static CancellationTokenSource tokenSource = null;

        public static void CallToChildThread()
        {
            try
            {
                System.Console.WriteLine("Child Thread Starts!");

                // Do Stuff lol
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    System.Console.WriteLine(i);
                }

                System.Console.WriteLine("Child Thread Completed!");
            }
            catch(ThreadAbortException ex)
            {
                System.Console.WriteLine($"Thread Abort Exception! - {ex}");
            }
            finally
            {
                System.Console.WriteLine("Thread Destroyed!");
            }
        }

        public static void StarterFunction(string[] args)
        {
            // Destroys Thread in .NET 5 or Later - https://docs.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/5.0/thread-abort-obsolete
            AbortThread();
            try
            {
                // Create Child Thread
                ThreadStart childRef = new ThreadStart(CallToChildThread);
                System.Console.WriteLine("In Main, Creating Child Thread");
                Thread childThread = new Thread(childRef);
                childThread.Start();

                // Stop Main Thread for 2000ms
                Thread.Sleep(2000);

                // Destroy Child Thread
                System.Console.WriteLine("In Main, Destroying Child Thread");

                // Destroys Thread in .NET 4 or Earlier
                // childThread.Abort(); 

                tokenSource.Cancel();

            }
            catch(OperationCanceledException e)
            {
                System.Console.WriteLine($"Child Thread Destroyed! - {e}");
            }
            finally
            {
                tokenSource.Dispose();
            }
        }

        // https://www.youtube.com/watch?v=TKc5A3exKBQ
        public static void AbortThread()
        {
            tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            if (token.IsCancellationRequested)
            {
                token.ThrowIfCancellationRequested();
            }
        }
    }
}
// pg 326, 327