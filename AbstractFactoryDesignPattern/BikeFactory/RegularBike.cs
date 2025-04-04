
using System;

namespace AbstractFactoryDesignPattern.BikeFactory
{
    internal class RegularBike : IBike
    {
        public void Ride()
        {
            Console.WriteLine("Regular Bike selected");
        }
    }
}
