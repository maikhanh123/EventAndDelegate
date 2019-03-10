using System;

namespace EventsAndDelegateCore
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending the message ..." + args.Video.Title);
        }
    }
}