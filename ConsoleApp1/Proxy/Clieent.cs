using System;

namespace DesignPatterns.ProxyExample
{
    public class Clieent
    {
        // The client code is supposed to work with all objects (both subjects and proxies)
        // via the Subject interface in order to support both real subjects and proxies.
        public void ClientCode(ISubject subject)
        {
            Console.WriteLine("Client: Executing the client code with a subject:");
            subject.Request();
        }
    }
}
