using System;
using System.Collections.Generic;

namespace ObserverableDesignPattern
{
    //This is Subject
    internal class YoutubeChannel : ISubject
    {
        private List<ISubscriber> _subscribers;
        public YoutubeChannel() {
            _subscribers = new List<ISubscriber>();
        }
        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }
        public void UploadVideo(string title)
        {
            Console.WriteLine($"\nUploading video: {title}");
            NotifySubscribers(title);
        }

        private void NotifySubscribers(string videoTitle)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(videoTitle);
            }
        }
    }
}
