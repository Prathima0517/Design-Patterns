using System;

namespace AbstractFactoryDesignPattern.BikeFactory
{
    internal class SportsBike: IBike
    {
        public void Ride()
        {
            Console.WriteLine("Sports Bike selected");
        }
    }
}
