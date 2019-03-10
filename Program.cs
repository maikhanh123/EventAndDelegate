using System;

namespace EventsAndDelegateCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video {Title = "Video 1"};
            var videoEncoder = new VideoEncoder();  //publisher or event sender
            var mailService = new MailService();  //subscriber or event receiver 
            var messageService = new MessageService();  //subscriber or event receiver

            //VideoEncoder don't know MailService and MessageService, it Loosely Coupled Applications
            //So we use delegate like the agreement/contract between publisher and subscriber
            //Determines the signature of the event handler method in Subcriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded1;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }
}
