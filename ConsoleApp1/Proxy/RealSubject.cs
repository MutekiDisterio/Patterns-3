using System;

namespace DesignPatterns.ProxyExample
{
    // The RealSubject contains some core business logic. 
    // Usually, RealSubjects are capable of doing some useful work.
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
