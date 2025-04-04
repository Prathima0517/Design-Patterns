
using AbstractFactoryDesignPattern.BikeFactory;
using AbstractFactoryDesignPattern.CarFactory;

namespace AbstractFactoryDesignPattern
{
    internal class RegularVehiclefactory : IVehicleFactory
    {
        public IBike BikeFactory()
        {
            return new RegularBike();
        }

        public ICar CarFactory()
        {
            return new RegularCar();
        }
    }
}
