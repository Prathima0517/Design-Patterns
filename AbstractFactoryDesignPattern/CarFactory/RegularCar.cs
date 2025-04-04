
using System;

namespace AbstractFactoryDesignPattern.CarFactory
{
    internal class RegularCar: ICar
    {
        public void Ride()
        {
            Console.WriteLine("Regular car selected");
        }
    }
}
