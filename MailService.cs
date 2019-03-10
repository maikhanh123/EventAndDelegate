using System;

namespace EventsAndDelegateCore
{
    public class MailService
    {
        public void OnVideoEncoded1(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}