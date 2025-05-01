using System;

namespace ObserverableDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = new YoutubeChannel();

            var s1 = new Subscriber("Subscriber1");
            var s2 = new Subscriber("Subscriber2");
            var s3 = new Subscriber("Subscriber3");

            channel.AddSubscriber(s1);
            channel.AddSubscriber(s2);
            channel.AddSubscriber(s3);

            channel.UploadVideo("Observer Pattern in C#");

            channel.RemoveSubscriber(s2);

            channel.UploadVideo("All design Pattern Explained");
            Console.ReadLine();
        }
    }
}
