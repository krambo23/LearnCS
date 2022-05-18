using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video video { get; set; }
    }

    public class VideoEncoder
    {
        // Define an Event
        // Step 1 - Define a Delegate
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // Step 2 - Define an Event Based on the Delegate
        // public event VideoEncodedEventHandler VideoEncoded;

        // Combine Steps 1 & 2 - If Need to Send Data via Arguments
        public event EventHandler<VideoEventArgs> VideoEncoded;

        // Combine Steps 1 & 2 - w/o Sending Data via Arguments
        // public event EventHandler VideoEncoded;

        // Step 3 - Raise / Publish the Event
        protected virtual void OnVideoEncoded(Video video)
        {
            // Notify Subscribers

            // Check if There are Subscribers
            if (VideoEncoded != null)
            {
                // No Arguments Are Passed
                // VideoEncoded(this, EventArgs.Empty);

                // Passing Arguments
                VideoEncoded(this, new VideoEventArgs()
                {
                    video = video
                });
            }
        }

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            // Raise / Publish Event
            OnVideoEncoded(video);
        }
    }
}