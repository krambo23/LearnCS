using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        // Subscriber
        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {
            System.Console.WriteLine($"{eventArgs.video.Title} - Sending Email...");
        }
    }
}