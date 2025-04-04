
using System;

namespace AbstractFactoryDesignPattern.CarFactory
{
    internal class SportsCar: ICar
    {
        public void Ride()
        {
            Console.WriteLine("Sports car selected");
        }
    }
}
