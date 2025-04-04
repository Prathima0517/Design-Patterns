
using AbstractFactoryDesignPattern.BikeFactory;
using AbstractFactoryDesignPattern.CarFactory;

namespace AbstractFactoryDesignPattern
{
    internal class SportsVehicleFactory: IVehicleFactory
    {
        public IBike BikeFactory()
        {
            return new SportsBike();
        }

        public ICar CarFactory()
        {
            return new SportsCar();
        }
    }
}
