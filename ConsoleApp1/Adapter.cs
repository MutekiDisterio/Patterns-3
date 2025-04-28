using System;

namespace DesignPatterns
{
    // Цільовий інтерфейс, який очікує клієнтський код
    public interface ITarget
    {
        string GetRequest();
    }

    // Клас, який потрібно адаптувати
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request from Adaptee.";
        }
    }

    // Адаптер: робить інтерфейс Adaptee сумісним із Target
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"Adapter: (TRANSLATED) '{_adaptee.GetSpecificRequest()}'";
        }
    }
}
