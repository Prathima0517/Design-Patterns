
using System;

namespace AbstractFactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Vehicle type:");
            string vehicleType=Console.ReadLine();

            IVehicleFactory vehicleFactory = GetVehicle(vehicleType);

            IBike bike = vehicleFactory.BikeFactory();
            bike.Ride();

            ICar car= vehicleFactory.CarFactory();           
            car.Ride();

            Console.ReadLine();

        }
        private static IVehicleFactory GetVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Regular":
                    return new RegularVehiclefactory();
                case "Sports":
                    return new SportsVehicleFactory();
                default:
                    throw new Exception("Wrong vehicle type selected");
            }
        }
    }
}
