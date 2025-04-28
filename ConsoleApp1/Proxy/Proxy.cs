using System;

namespace DesignPatterns.ProxyExample
{
    // The Proxy has an interface identical to the RealSubject.
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        // The Proxy controls the access, performs actions like logging, caching, or validation.
        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject.Request();
                LogAccess();
            }
        }

        // Example of additional proxy functionality
        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            // Actual access control logic could be added here
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
