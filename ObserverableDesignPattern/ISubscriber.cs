
namespace ObserverableDesignPattern
{
    internal interface ISubscriber
    {
        //To receive message from subject
        void Update(string videoTitle);
    }
}
