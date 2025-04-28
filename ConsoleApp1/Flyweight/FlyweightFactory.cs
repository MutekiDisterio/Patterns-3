using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Flyweight
{
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> _flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] cars)
        {
            foreach (var car in cars)
            {
                _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(car), GetKey(car)));
            }
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            var existing = _flyweights.FirstOrDefault(t => t.Item2 == key);
            if (existing == null)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                var flyweight = new Flyweight(sharedState);
                _flyweights.Add(new Tuple<Flyweight, string>(flyweight, key));
                return flyweight;
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
                return existing.Item1;
            }
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"\nFlyweightFactory: I have {_flyweights.Count} flyweights:");
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }

        private string GetKey(Car car)
        {
            List<string> elements = new List<string>
            {
                car.Company,
                car.Model,
                car.Color
            };

            if (!string.IsNullOrEmpty(car.Owner))
                elements.Add(car.Owner);

            if (!string.IsNullOrEmpty(car.Number))
                elements.Add(car.Number);

            elements.Sort();
            return string.Join("_", elements);
        }
    }
}
