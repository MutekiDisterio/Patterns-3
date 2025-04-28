using System;

namespace DesignPatterns.Decorator
{
    public class Clientt
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
