using System;

namespace DesignPatterns.Flyweight
{
    public static class Cliient
    {
        public static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
        {
            Console.WriteLine("\nClient: Adding a car to database.");

            var flyweight = factory.GetFlyweight(new Car
            {
                Company = car.Company,
                Model = car.Model,
                Color = car.Color
            });

            flyweight.Operation(car);
        }
    }
}
