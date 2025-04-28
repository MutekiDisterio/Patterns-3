namespace DesignPatterns.Bridge
{
    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: Result on platform B.";
        }
    }
}
