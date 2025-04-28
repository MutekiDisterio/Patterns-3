using System;

namespace DesignPatterns.Facade
{
    public static class Cllient
    {
        public static void ClientCode(Facades facades)
        {
            Console.Write(facades.Operation());
        }
    }
}
