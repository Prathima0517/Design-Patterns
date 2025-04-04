
namespace AbstractFactoryDesignPattern
{
    internal interface IVehicleFactory
    {
         IBike BikeFactory();
         ICar CarFactory();
    }
}
