using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // steps to publish event

        // 1 - Define a delegate (pointer to a method)
        // 2 - Define an event based on that delegate
        // 3 - Raise or publish the event

        // source of event (class that is sending the event) & any additional data sent with event
        /*        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e); // ref to function that looks like this*/

        // EventHandler or EventHandler<TEventArgs>

        /*        public event VideoEncodedEventHandler VideoEncoded; // defining event based on delegate*/

        // shorter way
        public event EventHandler<VideoEventArgs> VideoEncoded;

        // or without args public event EventHandler VideoEncoding;
        

        protected virtual void OnVideoEncoded(Video video) // .net suggests event publishers should be protected, virtual, and void and should start with On+name of event
        {
            if (VideoEncoded != null)
            {
                /* VideoEncoded(this, EventArgs.Empty); // empty bc no additional info*/
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video); // raising the event
        }
    }
}
