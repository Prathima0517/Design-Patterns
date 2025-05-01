
using System;

namespace ObserverableDesignPattern
{
    internal interface ISubject
    {
        void AddSubscriber(ISubscriber observer);
        void RemoveSubscriber(ISubscriber observer);
        void UploadVideo(string title);
    }
}
