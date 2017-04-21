namespace EventsAndDelegates
{
    using System;
    using System.Threading;

    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventhandler(object source, EventArgs e);

        //public event VideoEncodedEventhandler VideoEncoded;

         public event EventHandler<EventArgs> VideoEncoded;

        public void Encoder()
        {
            Console.WriteLine("Video is encoding...");
            Thread.Sleep(5000);
            this.OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (this.VideoEncoded != null)
            {
                this.VideoEncoded(this,EventArgs.Empty);
            }
        }


    }
}