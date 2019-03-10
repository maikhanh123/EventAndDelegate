using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegateCore
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; } //prop tab is shortcut for this 
    }

    public class VideoEncoder
    {
        // 1- Define a delegate
        //public delegate void VideoEncodeEventHandler(object source, EventArgs args);    //the event delegate provided in the class library for the no-data event

        public delegate void VideoEncodeEventHandler(object source, VideoEventArgs args); // use it if you want to sent data to
        // 2- Define an event based on that delegate
        //public event VideoEncodeEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded; 

        //This field like the agreement between publisher and subscriber
        //which this way you no need the step 1 to create a delegate

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video ...");
            Thread.Sleep(3000);

            // 3- Raise the event -> this one is notification to subscriber 
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
//            if (VideoEncoded != null)
//            {
//                VideoEncoded(this, new VideoEventArgs{Video = video});      //tranfer data for event
//            }

            VideoEncoded?.Invoke(this, new VideoEventArgs {Video = video}); //tranfer data for event
        }
    }
}