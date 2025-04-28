using System;
using Newtonsoft.Json;

namespace DesignPatterns.Flyweight
{
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string shared = JsonConvert.SerializeObject(this._sharedState);
            string unique = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {shared} and unique {unique} state.");
        }
    }
}
