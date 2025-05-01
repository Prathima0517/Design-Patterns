using System.Xml.Linq;
using System;

namespace ObserverableDesignPattern
{
    internal class Subscriber : ISubscriber
    {
        private readonly string _name;

        public Subscriber(string name)
        {
            _name = name;
        }
        public void Update(string videoTitle)
        {
            Console.WriteLine($"{_name} received notification: New video uploaded - {videoTitle}");
        }
    }
}
