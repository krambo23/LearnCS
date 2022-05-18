// https://www.youtube.com/watch?v=jQgwEsJISy0

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // Contains Publisher
            var mailService = new MailService(); // Contains Subscriber
            var messageService = new MessageService(); // Contains Subscriber

            // Subscribe to Publisher(s)
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}