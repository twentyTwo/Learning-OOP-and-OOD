using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "VideoTitle", Duration = "120" };
            var videoEncoder = new VideoEncoder();


            MessageService messageService = new MessageService();
            MailService mailService = new MailService();

            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encoder();

        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine("Sending the message to customer");
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine("Sending the mail to customer");
        }
    }
}
